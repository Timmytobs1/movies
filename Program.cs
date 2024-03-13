class Program{
    static List<int> store_movie = new List<int>();
    static void Main(){
        int flight_length = 80;
        List<int> movie_lengths = new List<int>(){34, 54, 60, 20, 10};
        
        for (int i = 0; i < movie_lengths.Count; i++)
        {
          for (int x = 0; x < movie_lengths.Count; x++)
          {
            if (i != x)
            {
              if (movie_lengths[i] + movie_lengths[x] < flight_length)
              {
                Console.WriteLine($"Movie {i + 1} and Movie {x + 1}");
              }
            }
          }
        }
        

    }

    
}