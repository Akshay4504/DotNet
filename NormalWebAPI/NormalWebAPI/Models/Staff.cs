namespace DockerWebAPI.Models
{
    public class Staff
    {
        public int staff_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public short active { get; set; }
        public int store_id { get; set; }
        public int manager_id { get; set; }
    }
}
