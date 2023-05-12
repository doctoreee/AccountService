namespace AccountService.Domain.Exceptions;

public class DomainExceptionContent
{
    public static ExceptionModel IdCannotBeEmpty = new(1001, "Id alanı boş geçilemez.");
    public static ExceptionModel FirstNameCannotBeEmpty = new(1002, "First Name alanı boş geçilemez.");
    public static ExceptionModel LastNameCannotBeEmpty = new(1003, "First Name alanı boş geçilemez.");
    public static ExceptionModel CannotFountAccount = new(1004, "Hesap bulunamadı.");
}
