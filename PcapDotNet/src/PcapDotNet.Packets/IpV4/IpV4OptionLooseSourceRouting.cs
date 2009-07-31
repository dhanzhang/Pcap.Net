namespace Packets
{
    public class IpV4OptionLooseSourceRouting : IpV4OptionRoute
    {
        public IpV4OptionLooseSourceRouting(IpV4Address[] addresses, byte pointedAddressIndex)
            : base(IpV4OptionType.LooseSourceRouting, addresses, pointedAddressIndex)
        {
        }

        internal static IpV4OptionLooseSourceRouting ReadOptionLooseSourceRouting(byte[] buffer, ref int offset, int length)
        {
            IpV4Address[] addresses;
            byte pointedAddressIndex;
            if (!TryRead(out addresses, out pointedAddressIndex, buffer, ref offset, length))
                return null;
            return new IpV4OptionLooseSourceRouting(addresses, pointedAddressIndex);
        }
    }
}