namespace CoreLib;

public class AccesShowCase
{
    public String PublicInfo = "Public OK";          // Tüm projelerde geçerli
    internal String InternalInfo = "Internal OK";    // Sadece bu projede geçerli.
    protected String ProtectedInfo = "Protected OK"; // Override eden projelerde geçerli.
    private String PrivateInfo = "Private OK";      // Sadece burada geçerli.

    public String ReadPrivateInside() => PrivateInfo; // erişim izni verdik.


}


