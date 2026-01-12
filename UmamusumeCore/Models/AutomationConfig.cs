namespace UmamusumeCore.Models;

// root of the whole file
public class AutomationConfig
{
    public AdbConfig  Adb        { get; set; } = new();
    public AutoConfig Automation { get; set; } = new();
}

// --------------- adb -----------------
public class AdbConfig
{
    public string Device_Address  { get; set; } = "";
    public string Screenshot_Path { get; set; } = "";
    public string Template_Path   { get; set; } = "";
    public bool   Pair           { get; set; }
    public string Pair_Address    { get; set; } = "";
    public string Pair_Code       { get; set; } = "";
}

// ------------- automation ------------
public class AutoConfig
{
    public WaitTimeConfig  WaitTime     { get; set; } = new();
    public AttemptsConfig  Attempts     { get; set; } = new();
    public bool            Manual_Choose { get; set; }
    public FilterConfig    Filter       { get; set; } = new();
    public CoordinatesConfig Coordinates { get; set; } = new();
}

// -- sub-objects ----------------------
public class WaitTimeConfig
{
    public float Career      { get; set; }
    public float Next        { get; set; }
    public float Start_Career { get; set; }
    public float Skip        { get; set; }
    public float Confirm     { get; set; }
    public float Loop        { get; set; }
}

public class AttemptsConfig
{
    public float Next      { get; set; }
    public float Next_Check { get; set; }
}

public class FilterConfig
{
    public string Rarity      { get; set; } = "";
    public string Speciality  { get; set; } = "";
}

public class CoordinatesConfig
{
    public short[] Tap_After_Skip { get; set; } = Array.Empty<short>();
}