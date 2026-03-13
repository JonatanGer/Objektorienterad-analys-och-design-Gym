MemberRepository memberRepo = new MemberRepository();
TrainingSessionRepository sessionRepo = new TrainingSessionRepository();
BookingRepository bookingRepo = new BookingRepository();

BookingService bookingService = new BookingService(bookingRepo, sessionRepo);

Member member = new Member(1, "Ali", "ali@mail.com", "1234");

TrainingSession session = new TrainingSession(1, "Yoga", DateTime.Now, DateTime.Now.AddHours(1), 10);
sessionRepo.Add(session);

string result = bookingService.BookSession(member, 1);

Console.WriteLine("Medlem: " + member.Name);
Console.WriteLine(result);
Console.ReadLine();