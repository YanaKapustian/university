namespace Tetris
{
    class Figure
    {
        public int Width;
        public int Height;
        public int[,] Dots;

        private int[,] backupDots;
        public void Turn()
        {
            // зберігати значення точок у резервних точках, щоб їх можна було просто використати для відкату
            backupDots = Dots;

            Dots = new int[Width, Height];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Dots[i, j] = backupDots[Height - 1 - j, i];
                }
            }

            var temp = Width;
            Width = Height;
            Height = temp;
        }

        // відкат відбувається, коли гравець обертає фігуру, але вона торкнеться інших фігур і її потрібно відмінити дію
        public void Rollback()
        {
            Dots = backupDots;

            var temp = Width;
            Width = Height;
            Height = temp;
        }
    }
}
