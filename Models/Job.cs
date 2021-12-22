namespace CSC_test_ASP.Models;

public enum JobStatus {
    pending,
    processed
}

public class Job {
    public int Id {get; set;}
    public string? Name {get; set;}
    public string? Status {get; set;}
    public int[]? Data {get; set;}
    public string? Result {get; set;}   
}

public class InputJob {
    public string? Name {get; set;}
    public int[]? Data {get; set;}
}