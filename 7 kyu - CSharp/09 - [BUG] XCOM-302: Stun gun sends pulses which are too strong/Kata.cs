namespace XCom.Weaponry
{
    public class StunVoltageModulator
    {
        // Maximum allowed voltage for the stun gun is 30kV (30,000 volts)
        private const int MAX_VOLTAGE = 30000;

        public void EmitShockPulse(uint initialVoltage, // changed to uint, see [XCOM-295]
                                   uint decrement,
                                   IStunee stunee)
        {
            // Cap the initial voltage to the maximum allowed (30kV)
            initialVoltage = System.Math.Min(initialVoltage, MAX_VOLTAGE);

            // Emit pulses, decreasing the voltage by the decrement, and stopping at 0 or below
            for (var level = initialVoltage; level > 0; level -= decrement)
            {
                // Check if stunee is null, skip the shock if no target is attached
                if (stunee != null)
                {
                    // Shock the target with the current voltage level
                    stunee.Shock(level);
                }

                // If decrement is greater than the current level, ensure we stop at 0
                if (level < decrement)
                {
                    break;
                }
            }
        }
    }
}
