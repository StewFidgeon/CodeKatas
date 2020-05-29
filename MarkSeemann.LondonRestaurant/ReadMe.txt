Exercise fixing Restaurant tests (in London style)
Source code
https://github.com/LexisNexis/tolley_training/tree/master/TDD_Refresher/Session_4/London_Restaurant_Exercise

Requirements
This commit comes with 5 FAILING TESTS. That's on purpose. The exercise is to make those 5 tests pass by properly defining the expected interaction between the SUT and its dependencies.

It's probably easiest to start with the MaïtreDTests, and then subsequently proceed to the ReservationsControllerTests.

You can use Moq for Test Doubles, but that's not required. Another option is to write Test Spies and Stubs by hand. Moq is already, however, available in the test project.

Hints
Note that the code uses XUnit rather than NUnit although that shouldn't have much impact.

Need to reverse engineer what the code is doing, e.g. the MaitreD class and the MaitreD.TryAccept() function for the MaitreDTests.

When initialising objects in the tests, create real instances of the any data objects (Reservation class) and the system under test (e.g. MaitreD class) but use Mock library to replace any collaborators (e.g. IReservationsRepository).