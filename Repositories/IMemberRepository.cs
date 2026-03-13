public interface IMemberRepository
{
    void Add(Member member);
    Member GetById(int memberId);
    List<Member> GetAll();
}