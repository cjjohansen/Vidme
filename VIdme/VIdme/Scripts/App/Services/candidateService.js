'use strict';

vidMeApp.factory('candidateService', function ($http, $log) {
    return {
        getCandidates: function (successCallBack) {
            $http({
                method: 'GET',
                url: 'api/candidates/'
            }).
            success(function (data, status, headers, config) {
                successCallBack(data);
            }).
            error(function (data, status, headers, config) {
                $log.warn(data, status, headers, config);
            });
        }
    }

});
