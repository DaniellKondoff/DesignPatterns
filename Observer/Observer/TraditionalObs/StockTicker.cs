namespace Observer.TraditionalObs
{
    public class StockTicker : AbstractSubject
    {
        private Stock stock;

        public Stock Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                stock = value;
                this.Notify();
            }
        }
    }
}
