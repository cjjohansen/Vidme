function candidatesController($scope) {
 
    $scope.candidates = [
      {
          id: 1,
          name: "Christian Johansen",
          rating: 3.5,
          email: "chr.j.johansen@gmail.com",
          photo: ""
      },
      {
          id:2,
          name: "Peter Petersen",
          rating: 5.0,
          email: "peter@mailinator.com",
          photo: ""
      }
    ];
}