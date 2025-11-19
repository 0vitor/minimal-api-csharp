public class TodoDto
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public bool IsComplete { get; set; }

    public TodoDto() { }
    public TodoDto(Todo todo)
    {
    (Id, Name, IsComplete) = (todo.Id, todo.Name, todo.IsComplete);
    }
}