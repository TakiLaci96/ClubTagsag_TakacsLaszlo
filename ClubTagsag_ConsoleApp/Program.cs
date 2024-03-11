using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClubTagsag_ConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Beolvasás a retool-ból
            string url = "https://retoolapi.dev/OEDUXm/member";
            List<Member> members = await GetMembersAsync(url);

            // Tagok száma: 
            Console.WriteLine($"Tagok száma: {members.Count}");

            // Ki lépett be utoljára:
            Member lastMember = members.FindLast(member => member.Entry != null);
            Console.WriteLine($"Ki lépett be utoljára: {lastMember.Fullname}");


            // Érdeklődési körökbe hányan tartoznak:
            Dictionary<string, int> interestCounts = new Dictionary<string, int>();

            foreach (Member member in members)
            {
                if (member.Interest != null)
                {
                    if (interestCounts.ContainsKey(member.Interest))
                    {
                        interestCounts[member.Interest]++;
                    } else
                    {
                        interestCounts.Add(member.Interest, 1);
                    }
                }
            }

            Console.WriteLine("Érdeklődési körök és a tagok száma:");

            foreach (var entry in interestCounts)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} tag");
            }

            Console.ReadLine();
        }

        static async Task<List<Member>> GetMembersAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    List<Member> members = JsonConvert.DeserializeObject<List<Member>>(json);
                    return members;
                } else
                {
                    throw new Exception($"Nem sikerült a beolvasás!");
                }
            }
        }
    }
}
