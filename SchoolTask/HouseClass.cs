using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_task
{

	public struct House
	{
		public int id;
		public string Name;
		public int bedroom;
		public int bathroom;
		public bool garage;
		public bool garden;
	}
	internal class HouseClass
	{
		private List<House> housesList;
		public HouseClass(int ID, string houseName, int bedroomCount = 0, int bathroomCount = 0, bool garageExist = false, bool gardenExist = false)
		{
			housesList = new List<House>();
			AddHouse(ID, houseName, bedroomCount, bathroomCount, garageExist, gardenExist);
		}

		public HouseClass()
		{
			housesList = new List<House>();
		}
		~HouseClass() { }

		private bool CheckList()
		{
			if (housesList.Count == 0)
			{
				return false;
			}
			return true;
		}
		public void AddHouse(int ID, string houseName, int bedroomCount = 0, int bathroomCount = 0, bool garageExist = false, bool gardenExist = false)
		{
			House newHouse = new House();

			newHouse.id = ID;
			newHouse.Name = houseName;
			newHouse.bedroom = bedroomCount;
			newHouse.bathroom = bathroomCount;
			newHouse.garage = garageExist;
			newHouse.garden = gardenExist;

			housesList.Add(newHouse);

			Console.WriteLine(housesList.Count);
		}

		public void AddHouse(House addingHouse)
		{
			housesList.Add(addingHouse);
		}

		public void GetAll()
		{
		}
		public void GetHouse(int ID)
		{
			if (!CheckList()) { Console.WriteLine("EMPTY DATABASE"); return; }
			foreach (House i in housesList)
			{
				if (i.id == ID)
				{
					Console.WriteLine("ID:" + i.id);
					Console.WriteLine("NAME: " + i.Name);
					Console.WriteLine("BEDROOM? " + i.bedroom);
					Console.WriteLine("BATHROOM:" + i.bathroom);
					Console.WriteLine("GARAGE? " + i.garage);
					Console.WriteLine("GARDEN? " + i.garden);

					return;
				}
			}
			Console.WriteLine("NO HOUSE OF THAT INDEX");
		}
		public void SetName(int ID, string houseName)
		{
			if (!CheckList()) { Console.WriteLine("EMPTY DATABASE"); return; }


			House currentHouse;
			for (int j = 0; j < housesList.Count; j++)
			{
				currentHouse = housesList[j];
				if (ID == currentHouse.id)
				{
					currentHouse.Name = houseName;
					housesList[j] = currentHouse;
					break;
				}
			}
		}
		public void SetBedroom(int ID, int houseBedroom)
		{
			if (!CheckList()) { Console.WriteLine("EMPTY DATABASE"); return; }


			House currentHouse;
			for (int j = 0; j < housesList.Count; j++)
			{
				currentHouse = housesList[j];
				if (ID == currentHouse.id)
				{
					currentHouse.bedroom = houseBedroom;
					housesList[j] = currentHouse;
					break;
				}
			}
		}
		public void SetBathroom(int ID, int houseBathroom)
		{
			if (!CheckList()) { Console.WriteLine("EMPTY DATABASE"); return; }


			House currentHouse;
			for (int j = 0; j < housesList.Count; j++)
			{
				currentHouse = housesList[j];
				if (ID == currentHouse.id)
				{
					currentHouse.bathroom = houseBathroom;
					housesList[j] = currentHouse;
					break;
				}
			}
		}
		public void SetGarage(int ID, bool houseGarage)
		{
			if (!CheckList()) { Console.WriteLine("EMPTY DATABASE"); return; }


			House currentHouse;
			for (int j = 0; j < housesList.Count; j++)
			{
				currentHouse = housesList[j];
				if (ID == currentHouse.id)
				{
					currentHouse.garage = houseGarage;
					housesList[j] = currentHouse;
					break;
				}
			}
		}
		public void SetGarden(int ID, bool houseGarden)
		{
			if (!CheckList()) { Console.WriteLine("EMPTY DATABASE"); return; }


			House currentHouse;
			for (int j = 0; j < housesList.Count; j++)
			{
				currentHouse = housesList[j];
				if (ID == currentHouse.id)
				{
					currentHouse.garden = houseGarden;
					housesList[j] = currentHouse;
					break;
				}
			}
		}
	}
}

