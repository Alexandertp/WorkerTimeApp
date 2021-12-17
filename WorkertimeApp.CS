
//A class for all data that workers might have attached to them, including name and hours worked.
public class Worker (fullName,isWorking,hoursWorked) {

    string fullName = get, set;
    //Checks whether a worker is 'clocked in' or not.
    bool isWorking = get, set;
    //A float containing how many hours a worker has worked.
    float hoursWorked = get, set;
}