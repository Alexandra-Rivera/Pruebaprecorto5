namespace Conexion_Hotel
{
    public class TablaAimeli
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Producto { get; set; }
        //public double Total { get; set; }
        
        

        public TablaAimeli()
        {
            this.Id = 0;
            this.Nombre = " ";
            this.Producto = " ";
            //this.Total = 0.00; 
        }

        public TablaAimeli(int id, string nombre, string direccion, string producto)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Producto = producto;
           // Total = total;
        }
    }
}    
