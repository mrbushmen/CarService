using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace CarServiceDB
{
    public partial class Form1 : Form
    {
        //Список идентификаторов автомобилей выбранного клиента
        //Используется на вкладке с заказами
        List<int> carsId = new List<int>();

        //Отображение идентификаторов в dataGridView
        bool isShowId = true;

        //Идентификаторы выбранной записи в dataGridView
        int curOwnerId;        
        int curWorkerId;        
        int curServiceId;        
        int curOrderId;        
        int curCarId;

        //Идентификаторы авто, услуги и работника
        //Используются на вкладке с заказами
        int carInOrder;
        int serviceInOrder;
        int workerInOrder;

        public Form1()
        {
            InitializeComponent();

            LoadAllDataAsync();
        }        

        #region Клиенты/владельцы автомобилей

        //Добавление клиента в базу
        private void BtnOwnerAdd_Click(object sender, EventArgs e)
        {            
            if (txtOwnerName.Text == string.Empty || txtOwnerPhone.Text == string.Empty)
            {
                MessageBox.Show("Заполните данные о клиенте");
                return;
            }

            using (MyContext db = new MyContext())
            {
                Owner owner = new Owner
                {
                    Name = txtOwnerName.Text,
                    Phone = txtOwnerPhone.Text
                };

                db.Owners.Add(owner);
                db.SaveChanges();
                LoadOwnersDataAsync();
            }
            txtOwnerName.Text = string.Empty;
            txtOwnerPhone.Text = string.Empty;
        }

        private void DataGridViewOwners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOwners.CurrentRow == null) return;
            if (!(dataGridViewOwners.CurrentRow.DataBoundItem is Owner owner)) return;

            txtOwnerPhone.Text = owner.Phone;
            txtOwnerName.Text = owner.Name;
            curOwnerId = owner.Id;

            //Отображение суммарной задолженности выбранного клиента
            txtUnpaid.Text = CalculateDebt(owner).ToString(); ;
        }

        //Редактирование данных клиента, выбранного в dataGridView
        private void BtnOwnerEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewOwners.SelectedCells == null) return;

            using (MyContext db = new MyContext())
            {
                Owner owner = db.Owners.Find(curOwnerId);
                if (owner == null) return;
                owner.Name = txtOwnerName.Text;
                owner.Phone = txtOwnerPhone.Text;
                db.Owners.AddOrUpdate(owner);
                db.SaveChanges();
            }
            LoadOwnersDataAsync();            
        }

        //Рассчет задолженности выбранного клиента
        decimal CalculateDebt(Owner owner)
        {
            using (MyContext db = new MyContext())
            {
                //Получение списка всех клиентов и их задолженностей за работы
                var result = from order in db.Orders.Where(p => p.Paid == false)
                             join car in db.Cars on order.Car equals car.Id
                             join ownr in db.Owners on car.OwnerId equals ownr.Id
                             join service in db.Services on order.Service equals service.Id
                             select new
                             {
                                 ownr.Name,
                                 service.Cost
                             };
                //Вычисление задолженности конкретного клиента
                var res = (from r in result.Where(p => p.Name == owner.Name)
                           group r by r.Name into grp
                           select new
                           {
                               Name = grp.Key,
                               TotalCost = grp.Sum(x => x.Cost),
                           }).ToList();
                if (res.Count > 0)
                    return res[0].TotalCost;
                else
                    return 0;

            }

        }

        #endregion

        #region Автомобили
        private void DataGridViewCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCars.CurrentRow == null) return;
            if (!(dataGridViewCars.CurrentRow.DataBoundItem is CarProjection car)) return;

            txtCarMark.Text = car.Mark;
            txtCarModel.Text = car.Model;
            txtCarYear.Text = car.Year.ToString();

            
            curOwnerId = car.OwnerId;
            curCarId = car.Id;            

            cmbCarOwner.SelectedItem = car.OwnerName;
        }

        private void BtnCarAdd_Click(object sender, EventArgs e)
        {            
            if (txtCarMark.Text == string.Empty || txtCarModel.Text == string.Empty || txtCarYear.Text == string.Empty)
            {
                MessageBox.Show("Заполните данные об автомобиле");
                return;
            }

            Car car = new Car
            {
                Mark = txtCarMark.Text,
                Model = txtCarModel.Text,
                Year = int.Parse(txtCarYear.Text),
                OwnerId = curOwnerId
            };

            using (MyContext db = new MyContext())
            {
                db.Cars.Add(car);
                db.SaveChanges();
            }
            LoadCarsDataAsync();

            txtCarMark.Text = string.Empty;
            txtCarModel.Text = string.Empty;
            txtCarYear.Text = string.Empty;
        }

        //Получение Id клиента при выборе его в comboBox на вкладке Автомобили
        private void CbCarOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MyContext db = new MyContext())
            {
                curOwnerId = db.Owners.ToList()[cmbCarOwner.SelectedIndex].Id;
            }
        }

        private void BtnCarEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars.SelectedCells == null) return;            

            using (MyContext db = new MyContext())
            {
                Car car = db.Cars.Find(curCarId);
                if (car == null) return;

                car.Mark = txtCarMark.Text;
                car.Model = txtCarModel.Text;
                car.Year = int.Parse(txtCarYear.Text);
                car.OwnerId = curOwnerId;
                car.Owner = db.Owners.Find(curOwnerId);

                db.Cars.AddOrUpdate(car);
                db.SaveChanges();
            }
            LoadCarsDataAsync();
        }

        #endregion
                
        #region Работники
        private void DataGridViewWorkers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewWorkers.CurrentRow == null) return;
            var worker = dataGridViewWorkers.CurrentRow.DataBoundItem as Worker;
            if (worker == null) return;

            txtWorkerName.Text = worker.Name;
            txtWorkerPhone.Text = worker.Phone;
            txtWorkerSpec.Text = worker.Specification;
                        
            curWorkerId = worker.Id;
        }

        private void BtnWorkerAdd_Click(object sender, EventArgs e)
        {
            if (txtWorkerName.Text == string.Empty || txtWorkerSpec.Text == string.Empty)
            {
                MessageBox.Show("Заполните данные о работнике");
                return;
            }

            using (MyContext db = new MyContext())
            {
                Worker worker = new Worker
                {
                    Name = txtWorkerName.Text,
                    Phone = txtWorkerPhone.Text,
                    Specification = txtWorkerSpec.Text
                };

                db.Workers.Add(worker);
                db.SaveChanges();
            }

            LoadWorkersDataAsync();

            txtWorkerName.Text = string.Empty;
            txtWorkerPhone.Text = string.Empty;
            txtWorkerSpec.Text = string.Empty;
        }

        private void BtnWorkerEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewWorkers.SelectedCells == null) return;

            using (MyContext db = new MyContext())
            {
                Worker worker = db.Workers.Find(curWorkerId);
                if (worker == null) return;
                worker.Name = txtWorkerName.Text;
                worker.Phone = txtWorkerPhone.Text;
                worker.Specification = txtWorkerSpec.Text;
                db.Workers.AddOrUpdate(worker);
                db.SaveChanges();
            }
            LoadWorkersDataAsync();
        }
        #endregion

        #region Услуги
        private void DataGridViewServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewServices.CurrentRow == null) return;
            if (!(dataGridViewServices.CurrentRow.DataBoundItem is Service service)) return;

            txtServiceType.Text = service.Type;
            txtServiceDescription.Text = service.Description;
            txtServiceCost.Text = service.Cost.ToString();
                        
            curServiceId = service.Id;
        }

        private void BtnServiceAdd_Click(object sender, EventArgs e)
        {
            if (txtServiceCost.Text == string.Empty || txtServiceType.Text == string.Empty)
            {
                MessageBox.Show("Заполните данные об услуге");
                return;
            }

            using (MyContext db = new MyContext())
            {
                Service service = new Service
                {
                    Type = txtServiceType.Text,
                    Description = txtServiceDescription.Text,
                    Cost = decimal.Parse(txtServiceCost.Text)
                };

                db.Services.Add(service);
                db.SaveChanges();

            }

            LoadServicesDataAsync();

            txtServiceType.Text = string.Empty;
            txtServiceDescription.Text = string.Empty;
            txtServiceCost.Text = string.Empty;
        }

        private void BtnServiceEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewServices.SelectedCells == null) return;

            using (MyContext db = new MyContext())
            {
                Service service = db.Services.Find(curServiceId);
                if (service == null) return;
                service.Type = txtServiceType.Text;
                service.Description = txtServiceDescription.Text;
                service.Cost = decimal.Parse(txtServiceCost.Text);
                db.Services.AddOrUpdate(service);
                db.SaveChanges();
            }
            LoadServicesDataAsync();
        }
        #endregion

        #region Заказы
        private void DataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrders.CurrentRow == null) return;
            if (!(dataGridViewOrders.CurrentRow.DataBoundItem is OrderProjection order)) return;

            curOrderId = order.Id;

            cmbOrdersCar.SelectedItem = order.CarModel;

            carInOrder = order.Car;
            checkBoxPaid.Checked = order.Paid;

            using (MyContext db = new MyContext())
            {
                Car car = db.Cars.Find(carInOrder);
                var owner = car.Owner.Name;
                cmbOrdersOwner.SelectedItem = owner;
            }

            cmbOrdersService.SelectedItem = order.ServiceType;
            cmbOrdersWorker.SelectedItem = order.WorkerName;
            dtpOrdersDate.Value = order.Date;

            serviceInOrder = order.Service;
            workerInOrder = order.Worker;
        }

        private void CbOrdersOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCMBOrdersCar();
        }

        private void BtnOrderAdd_Click(object sender, EventArgs e)
        {
            if (cmbOrdersOwner.SelectedIndex == -1 || cmbOrdersCar.SelectedIndex == -1 || cmbOrdersWorker.SelectedIndex == -1 || cmbOrdersService.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните данные о заказе");
                return;
            }

            Order order = new Order
            {
                Car = carInOrder,
                Service = serviceInOrder,
                Worker = workerInOrder,
                Date = dtpOrdersDate.Value,
                Paid = checkBoxPaid.Checked
            };

            using (MyContext db = new MyContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
            LoadOrdersDataAsync();

        }

        private void CbOrdersCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MyContext db = new MyContext())
            {
                carInOrder = carsId[cmbOrdersCar.SelectedIndex];
            }
        }

        private void CbOrdersService_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MyContext db = new MyContext())
            {
                db.Orders.Load();
                serviceInOrder = db.Services.ToList()[cmbOrdersService.SelectedIndex].Id;
            }
        }

        private void CbOrdersWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MyContext db = new MyContext())
            {
                workerInOrder = db.Workers.ToList()[cmbOrdersWorker.SelectedIndex].Id;
            }
        }

        private void BtnOrderEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedCells == null) return;            

            using (MyContext db = new MyContext())
            {
                Order order = db.Orders.Find(curOrderId);
                if (order == null) return;

                order.Car = carInOrder;
                order.Service = serviceInOrder;
                order.Worker = workerInOrder;
                order.Date = dtpOrdersDate.Value;
                order.Paid = checkBoxPaid.Checked;

                db.Orders.AddOrUpdate(order);
                db.SaveChanges();
            }
            LoadOrdersDataAsync();
        }
        #endregion

        #region Обновление/загрузка данных в выпадающие списки
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
                UpdateCMBCarOwner();
            if (tabControl1.SelectedIndex == 0)
                LoadDataInComboBoxes();
        }

        //Загружает данные во все выпадающие списки
        void LoadDataInComboBoxes()
        {
            UpdateCMBCarOwner();
            UpdateCMBOrdersService();
            UpdateCMBOrdersWorker();
        }

        private void UpdateCMBCarOwner()
        {
            cmbCarOwner.Items.Clear();
            cmbOrdersOwner.Items.Clear();
            using (MyContext db = new MyContext())
            {

                foreach (Owner o in db.Owners)
                {
                    cmbCarOwner.Items.Add(o.Name);
                    cmbOrdersOwner.Items.Add(o.Name);
                }
                if (cmbCarOwner.Items.Count >0)
                    cmbCarOwner.SelectedIndex = 0;
                if (cmbOrdersOwner.Items.Count > 0)
                    cmbOrdersOwner.SelectedIndex = 0;
            }
        }
                
        private void UpdateCMBOrdersCar()
        {
            carsId.Clear();
            cmbOrdersCar.Items.Clear();
            using (MyContext db = new MyContext())
            {
                int ownerId = db.Owners.ToList()[cmbOrdersOwner.SelectedIndex].Id;
                var cars = db.Cars.Where(p => p.OwnerId == ownerId);

                foreach (Car c in cars)
                {
                    carsId.Add(c.Id);
                    cmbOrdersCar.Items.Add(new StringBuilder(c.Mark + " " + c.Model + " " + c.Year.ToString()));
                }

                if (cmbOrdersCar.Items.Count > 0)
                    cmbOrdersCar.SelectedIndex = 0;
                else
                    cmbOrdersCar.Text = string.Empty;
            }
        }

        private void UpdateCMBOrdersService()
        {
            cmbOrdersService.Items.Clear();
            using (MyContext db = new MyContext())
            {
                foreach (Service s in db.Services)
                {
                    cmbOrdersService.Items.Add(s.Type);
                }

                if (cmbOrdersService.Items.Count > 0)
                    cmbOrdersService.SelectedIndex = 0;
                else
                    cmbOrdersService.Text = string.Empty;
            }
        }
        private void UpdateCMBOrdersWorker()
        {
            cmbOrdersWorker.Items.Clear();
            using (MyContext db = new MyContext())
            {
                foreach (Worker w in db.Workers)
                {
                    cmbOrdersWorker.Items.Add(w.Name);
                }

                if (cmbOrdersWorker.Items.Count > 0)
                    cmbOrdersWorker.SelectedIndex = 0;
                else
                    cmbOrdersWorker.Text = string.Empty;
            }
        }
        #endregion

        #region Методы загрузки/обновления данных в dataGridView

        //Загрузка данных во все элементы dataGridView и выпадающие списки
        private async void LoadAllDataAsync()
        {
            await LoadOwnersDataAsync();
            await LoadCarsDataAsync();
            await LoadWorkersDataAsync();
            await LoadServicesDataAsync();
            await LoadOrdersDataAsync();

            HideColumns();

            LoadDataInComboBoxes();
        }

        //Обновление данных о работниках в dataGridView
        private async Task LoadWorkersDataAsync()
        {
            using (MyContext db = new MyContext())
            {
                await db.Workers.LoadAsync();
                dataGridViewWorkers.DataSource = db.Workers.Include("Orders").ToList();
            }
        }

        //Обновление данных об услугах в dataGridView
        private async Task LoadServicesDataAsync()
        {
            using (MyContext db = new MyContext())
            {
                await db.Services.LoadAsync();
                dataGridViewServices.DataSource = db.Services.Include("Orders").ToList();
            }
        }

        //Обновление данных о клиентах в dataGridView
        private async Task LoadOwnersDataAsync()
        {
            using (MyContext db = new MyContext())
            {
                await db.Owners.LoadAsync();
                dataGridViewOwners.DataSource = db.Owners.Include("Cars").ToList();
            }
        }

        //Обновление данных о машинах в dataGridView
        private async Task LoadCarsDataAsync()
        {
            using (MyContext db = new MyContext())
            {
                await db.Cars.LoadAsync();

                var cars = db.Cars.Select(c => new CarProjection
                {
                    Id = c.Id,
                    Mark = c.Mark,
                    Model = c.Model,
                    Year = c.Year,
                    OwnerName = c.Owner.Name,
                    OwnerId = c.OwnerId
                });
                dataGridViewCars.DataSource = cars.ToList();
            }
        }

        //Обновление данных о заказах в dataGridView
        private async Task LoadOrdersDataAsync()
        {
            using (MyContext db = new MyContext())
            {
                await db.Orders.LoadAsync();

                var orders = db.Orders.Select(c => new OrderProjection
                {
                    Id = c.Id,
                    Car = c.Car,
                    Service = c.Service,
                    Worker = c.Worker,
                    Date = c.Date,
                    CarModel = c.Car1.Mark + " " + c.Car1.Model + " " + c.Car1.Year.ToString(),
                    ServiceType = c.Service1.Type,
                    WorkerName = c.Worker1.Name,
                    Paid = c.Paid
                });
                dataGridViewOrders.DataSource = orders.ToList();
            }
        }

        //Скрыть ненужные столбцы в таблицах
        void HideColumns()
        {
            //отключить столбец Cars у владельцев:
            dataGridViewOwners.Columns[3].Visible = false;

            //отключить столбец Orders у работников:
            dataGridViewWorkers.Columns[4].Visible = false;

            //отключить столбец с ID владельца в списке машин:
            dataGridViewCars.Columns[5].Visible = false;

            //отключить столбец Orders у услуг:
            dataGridViewServices.Columns[4].Visible = false;

            //Столбцы с Id машины, работника, услуги
            dataGridViewOrders.Columns[1].Visible = false;
            dataGridViewOrders.Columns[2].Visible = false;
            dataGridViewOrders.Columns[3].Visible = false;
        }
        #endregion

        #region Строка меню
        //Скрыть/показать идентификаторы в таблицах
        private void HideIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isShowId = !isShowId;
            dataGridViewOwners.Columns[0].Visible = isShowId;
            dataGridViewOrders.Columns[0].Visible = isShowId;
            dataGridViewCars.Columns[0].Visible = isShowId;
            dataGridViewServices.Columns[0].Visible = isShowId;
            dataGridViewWorkers.Columns[0].Visible = isShowId;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
