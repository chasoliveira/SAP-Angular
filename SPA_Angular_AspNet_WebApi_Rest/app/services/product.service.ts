import { Injectable } from '@angular/core';
import { Headers, Http, Response, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map'
import 'rxjs/add/operator/toPromise';
import 'rxjs/add/operator/first';

import { Product } from './../models/product';

@Injectable()
export class ProductService {
    constructor(private http: Http) { }

    private producturl = "http://localhost:20835/api/product";

    getAll() {
        return this.http.get(this.producturl, this.jwt())
            .toPromise()
            .then(res => res.json() as Product[])
            .catch(this.handleError);
    }
    private handleError(error: any): Promise<any> {
        console.error('An error occurred', error);
        return Promise.reject(error.message || error);
    }

    private jwt() {
        // create authorization header with jwt token
        let currentUser = JSON.parse(localStorage.getItem('currentUser'));
        if (currentUser && currentUser.access_token) {
            let headers = new Headers({
                'Authorization': 'Bearer ' + currentUser.access_token, withCredentials: true
            });
            return new RequestOptions({ headers: headers });
        }
    }
}