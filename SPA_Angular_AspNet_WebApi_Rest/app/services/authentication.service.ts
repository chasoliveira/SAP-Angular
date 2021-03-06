﻿import { Injectable } from '@angular/core';
import { Http, Headers, Response, RequestOptions, URLSearchParams, RequestMethod } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map'

@Injectable()
export class AuthenticationService {
    constructor(private http: Http) { }
    private authenticateUrl = "http://localhost:20835";
    login(username: string, password: string) {
        var body = `username=${username}&password=${password}&grant_type=password`;
        var bodyEconded = this.urlEncode({username:username, password: password, grant_type:'password'});
        console.log(body);
        return this.http.post(`${this.authenticateUrl}/Token`, bodyEconded, this.headerOptions())
            .toPromise()
            .then(response => {
                // login successful if there's a jwt token in the response
                let user = response.json();
                if (user && user.access_token) {
                    // store user details and jwt token in local storage to keep user logged in between page refreshes
                    localStorage.setItem('currentUser', JSON.stringify(user));
                }
            })
            .catch(this.handleError);
    }

    logout() {
        // remove user from local storage to log user out
        localStorage.removeItem('currentUser');
    }
    private handleError(error: any): Promise<any> {
        console.error('An error occurred', error);
        return Promise.reject(error.message || error);
    }
    private headerOptions() {
        let headers = new Headers({
            'Content-Type': 'application/x-www-form-urlencoded; charset=UTF8'
        });
        return new RequestOptions({ method: RequestMethod.Post,headers: headers });
    }
    private urlEncode(obj: Object): string {
        let urlSearchParams = new URLSearchParams();
        for (let key in obj) {
            urlSearchParams.append(key, obj[key]);
        }
        return urlSearchParams.toString();
    }
}