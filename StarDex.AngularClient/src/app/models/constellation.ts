import { Star } from './star';

export class Constellation {

  constructor(

    public Id: number,
    public Name: string,
    public Stars: Star[],
    public Description: string,
    public Top: number,
    public Left: number,
    public imageURL: string

  ) {}

}
