﻿// AutoGenerated File


export class UpdateProfileDto {

    id: number;

    firstName: string;

    lastName: string;

    bio: string;

    phone: string;

    email: string;

    address: string;

    city: string;

    state: string;

    isSelfQuarantined: boolean;

    zipCode: string;

    isDropOffPoint: boolean;

    /** Initializes a new instance of the UpdateProfileDto class **/
    public constructor(init?: Partial<UpdateProfileDto>) {
        Object.assign(this, init);
    }
}
