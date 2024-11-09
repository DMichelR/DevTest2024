import { VoteModel } from "@/models/VoteModel";

export type VoteAdapter = {
    id: string,
    optionId: string,
    voterEmail: string;
}

export function toVote(adapter: VoteAdapter): VoteModel {
    return {
        id: adapter.id,
        optionId: adapter.optionId,
        voterEmail: adapter.voterEmail
    }
}