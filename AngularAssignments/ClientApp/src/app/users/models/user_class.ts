import { IUserModel } from "./user_interface";


export class UserModel implements IUserModel{
    firstName: string;
    lastName: string;
    email: string;
    phone: string;
    
    constructor(){
        this.firstName = '';
        this.lastName = '';
        this.email = '';
        this.phone = '';
    }
}