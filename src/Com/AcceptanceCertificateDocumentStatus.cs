﻿using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace Diadoc.Api.Com
{
	[ComVisible(true)]
	[Guid("1851B149-A9DB-4F6B-AECF-D8DCE0B477F2")]
	//NOTE: Это хотели, чтобы можно было использовать XML-сериализацию для классов
	[XmlType(TypeName = "AcceptanceCertificateDocumentStatus", Namespace = "https://diadoc-api.kontur.ru")]
	public enum AcceptanceCertificateDocumentStatus
	{
		UnknownAcceptanceCertificateDocumentStatus = 0,
		OutboundWaitingForRecipientSignature = 1,
		OutboundWithRecipientSignature = 2,
		OutboundWithRecipientPartiallySignature = 19,
		OutboundRecipientSignatureRequestRejected = 3,
		OutboundWaitingForSenderSignature = 10,
		OutboundInvalidSenderSignature = 11,
		OutboundNoRecipientSignatureRequest = 16,
		InboundWaitingForRecipientSignature = 4,
		InboundWithRecipientSignature = 5,
		InboundWithRecipientPartiallySignature = 20,
		InboundRecipientSignatureRequestRejected = 6,
		InboundInvalidRecipientSignature = 12,
		InboundNoRecipientSignatureRequest = 17,
		InternalWaitingForRecipientSignature = 7,
		InternalWithRecipientSignature = 8,
		InternalWithRecipientPartiallySignature = 21,
		InternalRecipientSignatureRequestRejected = 9,
		InternalWaitingForSenderSignature = 13,
		InternalInvalidSenderSignature = 14,
		InternalInvalidRecipientSignature = 15,
		InternalNoRecipientSignatureRequest = 18
	}
}
