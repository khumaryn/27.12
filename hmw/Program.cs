using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace hmw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[4];

            users[0] = new User("user1", "passwordforuser1");
            users[1] = new User("user2", "passwordforuser2");
            users[2] = new User("user3", "passwordforuser3");
            users[3] = new User("user4", "passwordforuser4");
            string opt;
            do
            {
                Console.WriteLine("1.User elave et");
                Console.WriteLine("2.Userlara bax");
                Console.WriteLine("3. Userlar üzre axtarış et");
                opt = Console.ReadLine();
                if (opt == "3")
                {
                    Console.WriteLine("Axtaris deyerini daxil edin:");
                    string search = Console.ReadLine();

                    var filteredArr = SearchByName(users, search);

                    ShowUserInfo(filteredArr);
                }
                if (opt == "1")
                {
                    try
                    {
                        var user = CreateUser();
                        Array.Resize(ref users, users.Length + 1);
                        users[users.Length - 1] = user;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("yanlisdir");
                        Console.WriteLine("yanlis: " + e.Message);

                    }
                }
                if(opt== "2")
                {
                    users.GetInfo();
                }


            } while (true);
            static User[] SearchByName(User[] arr, string search)
            {
                User[] newArr = new User[0];

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].UserName.Contains(search))
                    {
                        Array.Resize(ref newArr, newArr.Length + 1);
                        newArr[newArr.Length - 1] = arr[i];
                    }
                }

                return newArr;
            }
            static void ShowUserInfo(User[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i].GetInfo());
                }
            }
            static User CreateUser()
            {
                Console.WriteLine("User yarat:");
                Console.WriteLine("User:");
                string _username = Console.ReadLine();
                string _password = Console.ReadLine();


                if (string.IsNullOrWhiteSpace(_username) || _username.Length < 6)
                {
                    throw new UserNameException("Name deyeri minimum 6 uzunlquda olmalidir!");
                }
                if (string.IsNullOrWhiteSpace(_password) || _password.Length < 8)
                {
                    throw new UserNameException("Name deyeri minimum 8 uzunlquda olmalidir!");
                }
                return new User (_username, _password);




            }
        }







}  }
        