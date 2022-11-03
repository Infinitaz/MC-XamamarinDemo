namespace crudOPXAM


{
    internal class jsonParse
    {
        public string price_usd { get; set; }
        public string volume24 { get; set; }

        public override string ToString()
        {
            return price_usd + volume24;
        }
    }
}