public class MemberRepository : IMemberRepository
{
    private List<Member> members = new List<Member>();

    public void Add(Member member)
    {
        members.Add(member);
    }

    public Member GetById(int memberId)
    {
        return members.FirstOrDefault(m => m.MemberId == memberId);
    }

    public List<Member> GetAll()
    {
        return members;
    }
}