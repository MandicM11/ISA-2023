export class RegisterRequest implements IRegisterRequest {
  username: string = "";
  password: string = "";
  email: string="";
  name : string = "";
  lastName : string = "";
  phoneNumber : string = "";
  occupation : string ="";
  companyInfo : string="";
  address: string="";
  constructor() {
  }

}

export interface IRegisterRequest {
  username: string,
  password: string,
  email :string,
  name : string,
  lastName:string,
  phoneNumber:string,
  occupation:string,
  companyInfo:string,
  address:string
};
