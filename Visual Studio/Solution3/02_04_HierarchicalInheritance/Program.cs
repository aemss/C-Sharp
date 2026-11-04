
using Log;

Logger logger = new Logger("Sistem başlatıldı");
logger.Log();

var fileLogger = new FileLogger("Kullanıcı giriş yaptı. ");
fileLogger.Log();

var secureFileLogger = new SecureFileLogger("Yetkisiz erişim denemesi!"," secure_log.txt");
secureFileLogger.Log();