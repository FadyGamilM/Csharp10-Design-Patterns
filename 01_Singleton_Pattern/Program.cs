using Singleton;

// get the instance 
var logger_1 = SingletonLogger.Instance;
logger_1.Log("msg from service (1)");

var logger_2 = SingletonLogger.Instance;
logger_2.Log("msg from service (2)");

var logger_3 = SingletonLogger.Instance;
logger_3.Log("msg from service (3)");