namespace LabsLibrary
{
    public static class Lab1Helper
    {
        public static string ProcessLab1Inputs(string[] inputData)
        {
            // Очікується, що inputData містить необхідну інформацію
            var nk = inputData[0].Split().Select(int.Parse).ToArray();
            int N = nk[0];
            int K = nk[1];
            var arrangement = inputData[1].Split().Select(int.Parse).ToList();

            // Виклик методу для розрахунку позиції
            int result = Lab1.FindPosition.CalculatePosition(N, K, arrangement);

            return result.ToString();
        }
    }


    public static class Lab2Helper
    {
        public static string CountLab2Ways(string[] inputData)
        {
            // Очікується, що inputData містить необхідну інформацію
            int N = int.Parse(inputData[0]);
            string[] times = inputData.Skip(1).Take(N).ToArray();

            // Виклик методу для розрахунку
            string result = Lab2.CalculateMin.CalculateMinimumAdjustmentTime(times);

            return result;
        }
    }


    public static class Lab3Helper
    {
            public static string FindLab3ShortestPath(string[] inputData)
            {
                // Розбір розмірів лабіринту
                string[] dimensions = inputData[0].Split(' ');
                int h = int.Parse(dimensions[0]);
                int m = int.Parse(dimensions[1]);
                int n = int.Parse(dimensions[2]);

                // Розбір самого лабіринту
                char[][][] labyrinth = ParseLabyrinth(inputData, h, m, n);

                // Виклик методу для пошуку принцеси
                int result = LabyrinthLib.LabyrinthSolver.FindPrincess(h, m, n, labyrinth);

                return result.ToString();
            }

            private static char[][][] ParseLabyrinth(string[] inputData, int h, int m, int n)
            {
                char[][][] labyrinth = new char[h][][];
                int lineIndex = 1; // Пропускаємо перший рядок із розмірами

                for (int z = 0; z < h; z++)
                {
                    labyrinth[z] = new char[m][];
                    for (int x = 0; x < m; x++)
                    {
                        labyrinth[z][x] = inputData[lineIndex++].ToCharArray();
                    }
                }

                return labyrinth;
            }
        }
    
}