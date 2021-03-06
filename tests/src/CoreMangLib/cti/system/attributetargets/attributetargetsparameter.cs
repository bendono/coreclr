using System;
/// <summary>
///Parameter
/// </summary>

public class AttributeTargetsParameter
{
    public static int Main()
    {
        AttributeTargetsParameter AttributeTargetsParameter = new AttributeTargetsParameter();

        TestLibrary.TestFramework.BeginTestCase("AttributeTargetsParameter");
        if (AttributeTargetsParameter.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
       TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
      
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Verify the AttributeTargets.Parameter value is 0x0800. ");
        try
        {
            int expectValue = 0x0800;
            if ((int)AttributeTargets.Parameter != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.1", " AttributeTargets.Parameter should return 0x0800.");
                retVal = false;
            }
           
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
       
        return retVal;
    }
   
}

