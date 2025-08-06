namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite school subject:");
            string subject = Console.ReadLine();
            string message = ""; // Initialize 'message' to avoid CS0165
            switch (subject.ToLower())
            {
                case "math":
                    message = "Math is interesting, I'm glad to hear it!";
                    break;
                case "science":
                    message = "Science helps us understand the universe and everything within it.";
                    break;
                case "history":
                    message = "History teaches us about our past, It is by far one of my favorites!";
                    break;
                case "art":
                    message = "Art allows us to make our dreams a reality.";
                    break;
                case "shop class":
                    message = "Shop allows young individuals to gain experience working with their hands.";
                    break;
                default:
                    message = "That's an interesting subject!";
                    break;
            }
            Console.WriteLine(message); // Move this after 'message' is assigned
        }
    }
}