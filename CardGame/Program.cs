namespace CardGame
{
    
    internal class Program
    {
        // Public static variables should follow PascalCasing.
        // Local variables should follow camelCasing.
        // Using TopRank dictionary to get rank equivalent of letter based special cards
        // like K for King, Q for Queen.
        static Dictionary<string, int> TopRank = new Dictionary<string, int>() {
            { "J", 11 },
            { "Q", 12 },
            { "K", 13 },
            { "A", 14 },
            { "j", 11 },
            { "q", 12 },
            { "k", 13 },
            { "a", 14 }
        };
        static int[] RankInInt = new int[5];

        // Method names should follow PascalCasing
        // Prints array with any type of data.
        void PrintArray<T>(IList<T> arr)
        {
            foreach (T obj in arr)
            {
                Console.WriteLine(obj);
            }

        }

        Boolean FourOfAKind(string[] rank)
        {
            // Converts the rank to int type and store in 'int' type array.
            // Used to get the value of special char such as 'K' , 'Q' , 'J' , 'A' to int equivalent values for comparison.
            for (int i = 0; i < 5; i++)
            {
                if (TopRank.ContainsKey(rank[i]))
                {
                    RankInInt[i] = TopRank[rank[i]];
                }
                else
                {
                    RankInInt[i] = Convert.ToInt32(rank[i]);
                }
            }

            // Sort int array
            Array.Sort(RankInInt);

            // 8 10 10 10 10  second == last
            // 1 1 1 1 2      first == lastBefore
            
            int first = RankInInt[0];
            int last = RankInInt[4];
            int second = RankInInt[1];
            int lastBefore = RankInInt[3];

            // Check the sorted array to verify if the first and last object
            // is not same since it will imply same objects within the entire sorted array.
            return (first != last) && (second == last || first == lastBefore);
        }

        //  Check if the ranks are in a sequence.
        Boolean IsSequence(string[] rank)
        {
            // Iterate through string array and get int equivalent of it to sort it.
            for (int i = 0; i < 5; i++)
            {
                if (TopRank.ContainsKey(rank[i]))
                {
                    RankInInt[i] = TopRank[rank[i]];
                }
                else
                {
                    RankInInt[i] = Convert.ToInt32(rank[i]);
                }
            }

            // Sort the int array.
            Array.Sort(RankInInt);
          
            // Checking if the int array is in sequence by comparing current and previous element.
            for (int i = 1; i < 5; i++)
            {
                
                if (RankInInt[i] != RankInInt[i - 1] + 1)
                {
                    return false;
                }
            }
            return true;
        }

        // Check if the suits are same.
        Boolean IsSameSuit(char[] suit)
        {
            for (int i = 1; i < 5; i++)
            {
                if (suit[i] != suit[i - 1])
                {
                    return false;
                }
            }
            return true;
        }


        Boolean RoyalFlush(string[] cardRanks)
        {
            // HashSet is used since the time complexity for checking if it contains a value is O(n).
            HashSet<string> topCards = new HashSet<string>() { "A", "J", "K", "Q", "10" };

            // Check if the cardRanks are in the top 5 rank values.
            foreach (string i in cardRanks)
            {
                if (!topCards.Contains(i))
                {
                    return false;
                }
            }
            return true;
        }
        

        Boolean IsPair(string[] rank)
        {
            HashSet<string> rankList = new HashSet<string>();

            
            foreach(string cardRank in rank)
            {
                // Checks if the card rank is already present. If it is present, then the pair is found.
                if (rankList.Contains(cardRank))
                {
                    return true;
                }
                else
                {
                    rankList.Add(cardRank);
                }
            }
            return false;

        }

        Boolean ThreeOfAKind(string[] rank)
        {
            Dictionary<string, int> rankCardDict = new Dictionary<string, int>();
            foreach(string rankCard in rank)
            {
                if (rankCardDict.ContainsKey(rankCard))
                {
                    // Check if two cards of the same card is already found.
                    // If then the third cards is also found so three is found.
                    if (rankCardDict[rankCard] == 2)
                    {
                        return true;
                    }

                    rankCardDict[rankCard]++;
                    
                }
                else
                {
                    rankCardDict[rankCard] = 1;
                }
            }
            return false;

        }

        Boolean TwoPair(string[] rank)
        {
            Dictionary<string, int> cardRankFrequencyDict = new Dictionary<string, int>();
            int pairCount = 0;
            foreach(string rankvalue in rank)
            {
                if (cardRankFrequencyDict.ContainsKey(rankvalue))
                {
                    cardRankFrequencyDict[rankvalue] += 1;

                    // If the two cards of same rank is found, increase the count of pairs found.
                    if (cardRankFrequencyDict[rankvalue] == 2)
                    {
                        pairCount++;
                    }

                }
                else
                {
                    cardRankFrequencyDict[rankvalue] = 1;
                }

            }
            return pairCount == 2;

        }

        Boolean FullHouse(string[] rank)
        {
            HashSet<string> cardRankSet = new HashSet<string>();
            
            // Since the values are added to the Set, the repeated values will be ignored.
            foreach (string rankvalue in rank)
            {
                cardRankSet.Add(rankvalue);

            }

            // If only two values is found, it means three same ranks got stored as a single values.
            // And two same ranks got stored as a single value.
            // Thus the count of set becomes 2.
            // Example: 5, 5, 5, 2, 2 gets stored in set as 5, 2.
            return cardRankSet.Count == 2;

        }
        void GetCombination(string[] cards)
        {

            // printArray<string>( cards);
            char[] suit = new char[5];
            string[] rank = new string[5];

            // Split the suit name and the rank values into two different string arrays.
            for (int i = 0; i < cards.Length; i++)
            {
                string currCard = cards[i];

                // The last character will always be the suit name.
                suit[i] = currCard[currCard.Length - 1];

                // The first character(5h) or the first two characters(10h) will be rank value.
                rank[i] = "" + currCard.Substring(0, currCard.Length - 1);
            }


            bool sameSuit = IsSameSuit(suit);
            if (sameSuit)
            {
                if (RoyalFlush(rank))
                {
                    Console.WriteLine("Royal Flush");
                }
                else if (IsSequence(rank))
                {
                    Console.WriteLine("Straight Flush");
                }
                else
                {
                    Console.WriteLine("Flush");
                }
            }
            else
            {
                // Different suit.

                if (FourOfAKind(rank))
                {
                    Console.WriteLine("Four of a kind");
                }
                else if (FullHouse(rank))
                {
                    Console.WriteLine("Full house");
                }


                else if (IsSequence(rank))
                {
                    Console.WriteLine("Straight");
                }
                else if (ThreeOfAKind(rank))
                {
                    Console.WriteLine("Three of a kind");
                }
                else if (TwoPair(rank)) 
                {
                    Console.WriteLine("Two pair");
                }
                else if(IsPair(rank))
                {
                    Console.WriteLine("Pair");
                }
                else
                {
                    // If none of the combinations apply and is not in sequence, then it's a 'High card'
                    Console.WriteLine("High card");
                }
            }
        }
        static void Main(string[] args)
        {
            // Royal flush.
            // { "Kh","Qh","Jh","Ah","10h" }

            // Straight flush.
            // { "2h" ,"4h" ,"3h" ,"1h" ,"5h" }


            // Four of a kind.
            // { "10s", "10c", "8d", "10d", "10h" }

             
            // Full house.
            // { "6c", "6h","6d", "kc","kh" }

            // Flush.
            // { "jd" ,"9d", "8d", "4d", "3d"  }

            // Straight.
            // { "10d","9s","8h","7d","6c" }

            // Three of a kind.
            // { "qc","qh","qs","9h","2s" }

            // Two pair.
            // { "2h", "3c","3s","2s","5d" }

            // Pair.
            // { "2h", "3c","4s","2s","5d" }

            new Program().GetCombination(new string[5] { "Kh", "Qh", "Jh", "Ah", "9h" });
        }
        
            
    }
    
}