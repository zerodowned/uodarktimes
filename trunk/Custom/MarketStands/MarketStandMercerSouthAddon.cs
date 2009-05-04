
////////////////////////////////////////
//                                    //
//      Generated by CEO's YAAAG      //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MarketStandMercerSouthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {5991, 0, 0, 7}, {5991, 0, 1, 7}, {3999, 0, 0, 7}// 8	10	20	
			, {3999, 0, -1, 7}, {3999, 0, -1, 8}// 21	22	
		};

 
        private static int[,] m_AddOnComplexComponents = new int[,] {
			  {3995, 0, 2, 1, 468, -1 }, {3996, 0, 2, 1, 711, -1 }, {5991, 0, 0, 7, 789, -1 }// 6	7	9	
			, {5991, 0, 1, 7, 734, -1 }, {5991, 0, 1, 8, 147, -1 }, {5991, 0, 1, 9, 369, -1 }// 11	12	13	
			, {5991, 0, 1, 10, 456, -1 }, {5991, 0, 1, 11, 649, -1 }, {5991, 0, 0, 8, 258, -1 }// 14	15	16	
			, {5991, 0, 0, 9, 38, -1 }, {5991, 0, 0, 10, 3, -1 }, {5989, 0, -1, 7, 123, -1 }// 17	18	19	
			, {3989, 1, 1, 1, 122, -1 }, {3992, 1, -1, 1, 587, -1 }, {3993, 1, 0, 1, 459, -1 }// 23	24	25	
					};

    
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MarketStandMercerSouthAddonDeed();
			}
		}

		[ Constructable ]
		public MarketStandMercerSouthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );

            for (int i = 0; i < m_AddOnComplexComponents.Length / 6; i++)
                AddComplexComponent( m_AddOnComplexComponents[i,0], m_AddOnComplexComponents[i,1], m_AddOnComplexComponents[i,2], m_AddOnComplexComponents[i,3], m_AddOnComplexComponents[i,4], m_AddOnComplexComponents[i,5] );

			AddComplexComponent( 2938, 0, 0, 1, 542, -1, "market stand" );// 1
			AddComplexComponent( 2938, 0, -1, 1, 542, -1, "market stand" );// 2
			AddComplexComponent( 6787, 0, -1, 0, 542, -1, "market stand" );// 3
			AddComplexComponent( 2938, 0, 1, 1, 542, -1, "market stand" );// 4
			AddComplexComponent( 6787, 0, 1, 0, 542, -1, "market stand" );// 5

		}

		public MarketStandMercerSouthAddon( Serial serial ) : base( serial )
		{
		}

        public void AddComplexComponent(int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(item, xoffset, yoffset, zoffset, hue, lightsource, null);
        }

        public void AddComplexComponent(int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class MarketStandMercerSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MarketStandMercerSouthAddon();
			}
		}

		[Constructable]
		public MarketStandMercerSouthAddonDeed()
		{
			Name = "MarketStandMercerSouth";
		}

		public MarketStandMercerSouthAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}