using System.Collections.Generic;
using Server.Items;

namespace Server.Mobiles
{
	public class SBHealer : SBInfo
	{
        private readonly List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
        private readonly IShopSellInfo m_SellInfo = new InternalSellInfo();

	    public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
                Add(new GenericBuyInfo(typeof(Bandage), 5, Utility.RandomMinMax(15, 25), 0xE21, 0));
                Add(new GenericBuyInfo(typeof(LesserHealPotion), 15, Utility.RandomMinMax(15, 25), 0xF0C, 0));
                Add(new GenericBuyInfo(typeof(Ginseng), 3, Utility.RandomMinMax(15, 25), 0xF85, 0));
                Add(new GenericBuyInfo(typeof(Garlic), 3, Utility.RandomMinMax(15, 25), 0xF84, 0));
                Add(new GenericBuyInfo(typeof(RefreshPotion), 15, Utility.RandomMinMax(15, 25), 0xF0B, 0));
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( Bandage ), 1 );
				Add( typeof( LesserHealPotion ), 7 );
				Add( typeof( RefreshPotion ), 7 );
				Add( typeof( Garlic ), 2 );
				Add( typeof( Ginseng ), 2 );
			}
		}
	}
}