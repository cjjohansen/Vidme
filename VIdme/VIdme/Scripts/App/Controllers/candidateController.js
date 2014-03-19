'use strict';

vidMeApp.controller('candidatesCtrl', function candidatesCtrl($scope, candidateService) {
     candidateService.getCandidates(function(candidates) {
         $scope.candidates = candidates;
    });

    //$scope.candidates = [
    //    {
    //        name: 'Christian Johansen',
    //        rating: 3,
    //        image: 'http://localhost/Content/images/portrait_70x70.jpg'
    //    },
    //    {
    //        name: 'Hans Henrik Johansen',
    //        rating: 3,
    //        image: '~/Content/images/portrait_70x70.jpg'
    //    },
    //    {
    //        name: 'Kate Johansen',
    //        rating: 3,
    //        image: '~/Content/images/portrait_70x70.jpg'
    //    }

    //];
    //$Scope.settings = ratingCtrl;
});