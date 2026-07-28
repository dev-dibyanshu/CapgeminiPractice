class CommercialCustomer : IBillCalculator
{
    public double CalculateBill(double units, double rate, double fixedCharges)
    {
        // Commercial customers pay an extra 10%
        return ((units * rate) * 1.10) + fixedCharges;
    }
}