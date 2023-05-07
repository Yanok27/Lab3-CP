using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3_CP_.Models;
using LAB3_CP_.Enums;

namespace LAB3_CP_.Data
{
    public class DataContext:IDContext
    {
        public IEnumerable<Motherboard> Motherboards => new List<Motherboard>()
        {
            new Motherboard()
            {
                SKU="MB001",
                Name="ASUS Prime Z590-P",
                Price=250,
                SocketType=SocketType.LGA,
                Chipset=ChipsetType.Intel_Z690,
                ProcessorCount=1,
                MemoryType=MemoryType.DDR3,
                BusSpeed=2133

            },
            new Motherboard()
            {
                SKU="MB002",
                Name="MSI B450 TOMAHAWK",
                Price=120,
                SocketType=SocketType.PGA,
                Chipset=ChipsetType.Intel_Z590,
                ProcessorCount=1,
                MemoryType=MemoryType.DDR4,
                BusSpeed=2400
            },
            new Motherboard()
            {
                SKU="MB003",
                Name="Gigabyte Z590 AORUS",
                Price=350,
                SocketType=SocketType.BGA,
                Chipset=ChipsetType.Intel_B560,
                ProcessorCount=2,
                MemoryType=MemoryType.DDR5,
                BusSpeed=2666
            },
            new Motherboard()
            {
                SKU="MB004",
                Name="ASRock B450M PRO4",
                Price=90,
                SocketType=SocketType.TR4,
                Chipset=ChipsetType.AMD_X570,
                ProcessorCount=1,
                MemoryType=MemoryType.LPDDR4,
                BusSpeed=3200
            },
            new Motherboard()
            {
                SKU="MB005",
                Name="ASUS ROG Strix Z590-E",
                Price=450,
                SocketType=SocketType.LGA,
                Chipset=ChipsetType.AMD_B550,
                ProcessorCount=1,
                MemoryType=MemoryType.DDR4L,
                BusSpeed=3600
            },

        };
        public IEnumerable<HardDrive> HardDrives => new List<HardDrive>()
        {
            new HardDrive()
            {
                SKU="HD001",
                Name="Seagate Barracuda",
                Price=1500,
                Capacity=1,
                Speed=7200,
                Interface=InterfaceType.SATA
            },
            new HardDrive()
            {
                SKU="HD002",
                Name="Western Digital Blue",
                Price=2500,
                Capacity=2,
                Speed=5400,
                Interface=InterfaceType.SCSI
            },
            new HardDrive()
            {
                SKU="HD003",
                Name="Toshiba P300",
                Price=2000,
                Capacity=3,
                Speed=7200,
                Interface=InterfaceType.SAS
            },
            new HardDrive()
            {
                SKU="HD004",
                Name="Seagate IronWolf",
                Price=3500,
                Capacity=4,
                Speed=7200,
                Interface=InterfaceType.SATA
            },
            new HardDrive()
            {
                SKU="HD005",
                Name="Samsung 970 EVO",
                Price=1900,
                Capacity=1,
                Speed=3500,
                Interface=InterfaceType.IDE
            }
        };
        public IEnumerable<Memory> Memories => new List<Memory>()
        {
            new Memory()
            {
                SKU="RAM001",
                Name="Kingston HyperX",
                Price=500,
                Capacity=8,
                MemoryType=MemoryType.DDR3,
                ClockSpeed=2666,
                Count=1
            },
             new Memory()
            {
                SKU="RAM002",
                Name="Corsair Vengeance",
                Price=800,
                Capacity=16,
                MemoryType=MemoryType.DDR4,
                ClockSpeed=3200,
                Count=2
            },
              new Memory()
            {
                SKU="RAM003",
                Name="Crucial Ballistix",
                Price=650,
                Capacity=16,
                MemoryType=MemoryType.DDR5,
                ClockSpeed=3600,
                Count=1
            },
               new Memory()
            {
                SKU="RAM004",
                Name="G.Skill Trident Z",
                Price=1200,
                Capacity=32,
                MemoryType=MemoryType.LPDDR5,
                ClockSpeed=3200,
                Count=4
            },
             new Memory()
            {
                SKU="RAM005",
                Name="Team T-Force Xtreem",
                Price=1500,
                Capacity=32,
                MemoryType=MemoryType.DDR3,
                ClockSpeed=3600,
                Count=4
            }
        };
        public IEnumerable<Processor> Processors => new List<Processor>()
        {
            new Processor()
            {
                SKU="CPU001",
                Name="Intel Core i5-11600K",
                Price=4500,
                ConnectorType=ConnectorType.Socket7,
                CoreCount=6,
                ClockSpeed=3.9
            },
            new Processor()
            {
                SKU="CPU002",
                Name="AMD Ryzen 7 5800X",
                Price=3500,
                ConnectorType=ConnectorType.Slot1,
                CoreCount=8,
                ClockSpeed=3.8
            },
            new Processor()
            {
                SKU="CPU003",
                Name="Intel Core i9-11900K",
                Price=6000,
                ConnectorType=ConnectorType.Socket370,
                CoreCount=8,
                ClockSpeed=3.5
            },
            new Processor()
            {
                SKU="CPU004",
                Name="AMD Ryzen 9 5900X",
                Price=5500,
                ConnectorType=ConnectorType.Socket939,
                CoreCount=12,
                ClockSpeed=3.6
            },
            new Processor()
            {
                SKU="CPU005",
                Name="Intel Core i7-11700K",
                Price=7500,
                ConnectorType=ConnectorType.Socket478,
                CoreCount=8,
                ClockSpeed=3.6
            }
        };
    }
}
