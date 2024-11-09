import { PollModel } from "@/models/PollModel";
import { API_URL } from "./api.constants";
import { json } from "stream/consumers";
import { PollAdapter, toPoll } from "@/adapters/PollAdapter";

export async function getAllPolls(): Promise<PollModel[]> {
    const response = await fetch(`${API_URL}/polls`)
    const data = (await response.json()) as PollAdapter[];

    const polls = data.map(p => toPoll(p));
    return polls;
}