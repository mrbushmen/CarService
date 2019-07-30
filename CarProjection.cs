namespace CarServiceDB
{
    //Класс для представления информации об автомобилях в заданной форме
    public class CarProjection
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public  string Model { get; set; }
        public int Year { get; set; }
        public string OwnerName { get; set; }
        public int OwnerId { get; set; }

    }
}
