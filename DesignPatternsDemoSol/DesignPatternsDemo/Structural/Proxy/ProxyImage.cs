namespace DesignPatternsDemo.Structural.Proxy
{
    public class ProxyImage : IImage
    {
        private RealImage realImage;

        public ProxyImage(RealImage realImage)
        {
            this.realImage = realImage;
        }

        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage();
            }

            realImage.Display();
        }
    }
}
