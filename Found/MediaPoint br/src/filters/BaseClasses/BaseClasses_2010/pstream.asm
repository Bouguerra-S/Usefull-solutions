; Listing generated by Microsoft (R) Optimizing Compiler Version 16.00.30319.01 

	TITLE	C:\Downloads\MediaPoint\src\filters\BaseClasses\pstream.cpp
	.686P
	.XMM
	include listing.inc
	.model	flat

INCLUDELIB LIBCMTD
INCLUDELIB OLDNAMES

PUBLIC	_IID_IAMFilterGraphCallback
CONST	SEGMENT
$SG81597 DB	'%', 00H, '0', 00H, '1', 00H, '1', 00H, 'd', 00H, ' ', 00H
	DB	00H, 00H
CONST	ENDS
;	COMDAT _IID_IAMFilterGraphCallback
CONST	SEGMENT
_IID_IAMFilterGraphCallback DD 056a868fdH
	DW	0ad4H
	DW	011ceH
	DB	0b0H
	DB	0a3H
	DB	00H
	DB	020H
	DB	0afH
	DB	0bH
	DB	0a7H
	DB	070H
CONST	ENDS
PUBLIC	?GetSoftwareVersion@CPersistStream@@UAEKXZ	; CPersistStream::GetSoftwareVersion
PUBLIC	??_7CPersistStream@@6B@				; CPersistStream::`vftable'
PUBLIC	??0IPersistStream@@QAE@XZ			; IPersistStream::IPersistStream
PUBLIC	??0CPersistStream@@QAE@PAUIUnknown@@PAJ@Z	; CPersistStream::CPersistStream
PUBLIC	??_R4CPersistStream@@6B@			; CPersistStream::`RTTI Complete Object Locator'
PUBLIC	??_R0?AVCPersistStream@@@8			; CPersistStream `RTTI Type Descriptor'
PUBLIC	??_R3CPersistStream@@8				; CPersistStream::`RTTI Class Hierarchy Descriptor'
PUBLIC	??_R2CPersistStream@@8				; CPersistStream::`RTTI Base Class Array'
PUBLIC	??_R1A@?0A@EA@CPersistStream@@8			; CPersistStream::`RTTI Base Class Descriptor at (0,-1,0,64)'
PUBLIC	??_R1A@?0A@EA@IPersistStream@@8			; IPersistStream::`RTTI Base Class Descriptor at (0,-1,0,64)'
PUBLIC	??_R0?AUIPersistStream@@@8			; IPersistStream `RTTI Type Descriptor'
PUBLIC	??_R3IPersistStream@@8				; IPersistStream::`RTTI Class Hierarchy Descriptor'
PUBLIC	??_R2IPersistStream@@8				; IPersistStream::`RTTI Base Class Array'
PUBLIC	??_R1A@?0A@EA@IPersist@@8			; IPersist::`RTTI Base Class Descriptor at (0,-1,0,64)'
PUBLIC	??_R0?AUIPersist@@@8				; IPersist `RTTI Type Descriptor'
PUBLIC	??_R3IPersist@@8				; IPersist::`RTTI Class Hierarchy Descriptor'
PUBLIC	??_R2IPersist@@8				; IPersist::`RTTI Base Class Array'
PUBLIC	??_R1A@?0A@EA@IUnknown@@8			; IUnknown::`RTTI Base Class Descriptor at (0,-1,0,64)'
PUBLIC	??_R0?AUIUnknown@@@8				; IUnknown `RTTI Type Descriptor'
PUBLIC	??_R3IUnknown@@8				; IUnknown::`RTTI Class Hierarchy Descriptor'
PUBLIC	??_R2IUnknown@@8				; IUnknown::`RTTI Base Class Array'
PUBLIC	?IsDirty@CPersistStream@@UAGJXZ			; CPersistStream::IsDirty
PUBLIC	?Load@CPersistStream@@UAGJPAUIStream@@@Z	; CPersistStream::Load
PUBLIC	?Save@CPersistStream@@UAGJPAUIStream@@H@Z	; CPersistStream::Save
PUBLIC	?GetSizeMax@CPersistStream@@UAGJPAT_ULARGE_INTEGER@@@Z ; CPersistStream::GetSizeMax
PUBLIC	?SizeMax@CPersistStream@@UAEHXZ			; CPersistStream::SizeMax
PUBLIC	?WriteToStream@CPersistStream@@UAEJPAUIStream@@@Z ; CPersistStream::WriteToStream
PUBLIC	?ReadFromStream@CPersistStream@@UAEJPAUIStream@@@Z ; CPersistStream::ReadFromStream
EXTRN	__RTC_CheckEsp:PROC
EXTRN	__RTC_Shutdown:PROC
EXTRN	__RTC_InitBase:PROC
EXTRN	??_7type_info@@6B@:QWORD			; type_info::`vftable'
EXTRN	__purecall:PROC
;	COMDAT ??_R2IUnknown@@8
; File c:\downloads\mediapoint\src\filters\baseclasses\pstream.cpp
rdata$r	SEGMENT
??_R2IUnknown@@8 DD FLAT:??_R1A@?0A@EA@IUnknown@@8	; IUnknown::`RTTI Base Class Array'
rdata$r	ENDS
;	COMDAT ??_R3IUnknown@@8
rdata$r	SEGMENT
??_R3IUnknown@@8 DD 00H					; IUnknown::`RTTI Class Hierarchy Descriptor'
	DD	00H
	DD	01H
	DD	FLAT:??_R2IUnknown@@8
rdata$r	ENDS
;	COMDAT ??_R0?AUIUnknown@@@8
_DATA	SEGMENT
??_R0?AUIUnknown@@@8 DD FLAT:??_7type_info@@6B@		; IUnknown `RTTI Type Descriptor'
	DD	00H
	DB	'.?AUIUnknown@@', 00H
_DATA	ENDS
;	COMDAT ??_R1A@?0A@EA@IUnknown@@8
rdata$r	SEGMENT
??_R1A@?0A@EA@IUnknown@@8 DD FLAT:??_R0?AUIUnknown@@@8	; IUnknown::`RTTI Base Class Descriptor at (0,-1,0,64)'
	DD	00H
	DD	00H
	DD	0ffffffffH
	DD	00H
	DD	040H
	DD	FLAT:??_R3IUnknown@@8
rdata$r	ENDS
;	COMDAT ??_R2IPersist@@8
rdata$r	SEGMENT
??_R2IPersist@@8 DD FLAT:??_R1A@?0A@EA@IPersist@@8	; IPersist::`RTTI Base Class Array'
	DD	FLAT:??_R1A@?0A@EA@IUnknown@@8
rdata$r	ENDS
;	COMDAT ??_R3IPersist@@8
rdata$r	SEGMENT
??_R3IPersist@@8 DD 00H					; IPersist::`RTTI Class Hierarchy Descriptor'
	DD	00H
	DD	02H
	DD	FLAT:??_R2IPersist@@8
rdata$r	ENDS
;	COMDAT ??_R0?AUIPersist@@@8
_DATA	SEGMENT
??_R0?AUIPersist@@@8 DD FLAT:??_7type_info@@6B@		; IPersist `RTTI Type Descriptor'
	DD	00H
	DB	'.?AUIPersist@@', 00H
_DATA	ENDS
;	COMDAT ??_R1A@?0A@EA@IPersist@@8
rdata$r	SEGMENT
??_R1A@?0A@EA@IPersist@@8 DD FLAT:??_R0?AUIPersist@@@8	; IPersist::`RTTI Base Class Descriptor at (0,-1,0,64)'
	DD	01H
	DD	00H
	DD	0ffffffffH
	DD	00H
	DD	040H
	DD	FLAT:??_R3IPersist@@8
rdata$r	ENDS
;	COMDAT ??_R2IPersistStream@@8
rdata$r	SEGMENT
??_R2IPersistStream@@8 DD FLAT:??_R1A@?0A@EA@IPersistStream@@8 ; IPersistStream::`RTTI Base Class Array'
	DD	FLAT:??_R1A@?0A@EA@IPersist@@8
	DD	FLAT:??_R1A@?0A@EA@IUnknown@@8
rdata$r	ENDS
;	COMDAT ??_R3IPersistStream@@8
rdata$r	SEGMENT
??_R3IPersistStream@@8 DD 00H				; IPersistStream::`RTTI Class Hierarchy Descriptor'
	DD	00H
	DD	03H
	DD	FLAT:??_R2IPersistStream@@8
rdata$r	ENDS
;	COMDAT ??_R0?AUIPersistStream@@@8
_DATA	SEGMENT
??_R0?AUIPersistStream@@@8 DD FLAT:??_7type_info@@6B@	; IPersistStream `RTTI Type Descriptor'
	DD	00H
	DB	'.?AUIPersistStream@@', 00H
_DATA	ENDS
;	COMDAT ??_R1A@?0A@EA@IPersistStream@@8
rdata$r	SEGMENT
??_R1A@?0A@EA@IPersistStream@@8 DD FLAT:??_R0?AUIPersistStream@@@8 ; IPersistStream::`RTTI Base Class Descriptor at (0,-1,0,64)'
	DD	02H
	DD	00H
	DD	0ffffffffH
	DD	00H
	DD	040H
	DD	FLAT:??_R3IPersistStream@@8
rdata$r	ENDS
;	COMDAT ??_R1A@?0A@EA@CPersistStream@@8
rdata$r	SEGMENT
??_R1A@?0A@EA@CPersistStream@@8 DD FLAT:??_R0?AVCPersistStream@@@8 ; CPersistStream::`RTTI Base Class Descriptor at (0,-1,0,64)'
	DD	03H
	DD	00H
	DD	0ffffffffH
	DD	00H
	DD	040H
	DD	FLAT:??_R3CPersistStream@@8
rdata$r	ENDS
;	COMDAT ??_R2CPersistStream@@8
rdata$r	SEGMENT
??_R2CPersistStream@@8 DD FLAT:??_R1A@?0A@EA@CPersistStream@@8 ; CPersistStream::`RTTI Base Class Array'
	DD	FLAT:??_R1A@?0A@EA@IPersistStream@@8
	DD	FLAT:??_R1A@?0A@EA@IPersist@@8
	DD	FLAT:??_R1A@?0A@EA@IUnknown@@8
rdata$r	ENDS
;	COMDAT ??_R3CPersistStream@@8
rdata$r	SEGMENT
??_R3CPersistStream@@8 DD 00H				; CPersistStream::`RTTI Class Hierarchy Descriptor'
	DD	00H
	DD	04H
	DD	FLAT:??_R2CPersistStream@@8
rdata$r	ENDS
;	COMDAT ??_R0?AVCPersistStream@@@8
_DATA	SEGMENT
??_R0?AVCPersistStream@@@8 DD FLAT:??_7type_info@@6B@	; CPersistStream `RTTI Type Descriptor'
	DD	00H
	DB	'.?AVCPersistStream@@', 00H
_DATA	ENDS
;	COMDAT ??_R4CPersistStream@@6B@
rdata$r	SEGMENT
??_R4CPersistStream@@6B@ DD 00H				; CPersistStream::`RTTI Complete Object Locator'
	DD	00H
	DD	00H
	DD	FLAT:??_R0?AVCPersistStream@@@8
	DD	FLAT:??_R3CPersistStream@@8
rdata$r	ENDS
;	COMDAT ??_7CPersistStream@@6B@
CONST	SEGMENT
??_7CPersistStream@@6B@ DD FLAT:??_R4CPersistStream@@6B@ ; CPersistStream::`vftable'
	DD	FLAT:__purecall
	DD	FLAT:__purecall
	DD	FLAT:__purecall
	DD	FLAT:__purecall
	DD	FLAT:?IsDirty@CPersistStream@@UAGJXZ
	DD	FLAT:?Load@CPersistStream@@UAGJPAUIStream@@@Z
	DD	FLAT:?Save@CPersistStream@@UAGJPAUIStream@@H@Z
	DD	FLAT:?GetSizeMax@CPersistStream@@UAGJPAT_ULARGE_INTEGER@@@Z
	DD	FLAT:?GetSoftwareVersion@CPersistStream@@UAEKXZ
	DD	FLAT:?SizeMax@CPersistStream@@UAEHXZ
	DD	FLAT:?WriteToStream@CPersistStream@@UAEJPAUIStream@@@Z
	DD	FLAT:?ReadFromStream@CPersistStream@@UAEJPAUIStream@@@Z
CONST	ENDS
;	COMDAT rtc$TMZ
rtc$TMZ	SEGMENT
__RTC_Shutdown.rtc$TMZ DD FLAT:__RTC_Shutdown
rtc$TMZ	ENDS
;	COMDAT rtc$IMZ
rtc$IMZ	SEGMENT
__RTC_InitBase.rtc$IMZ DD FLAT:__RTC_InitBase
; Function compile flags: /Odtp /RTCsu
rtc$IMZ	ENDS
;	COMDAT ??0CPersistStream@@QAE@PAUIUnknown@@PAJ@Z
_TEXT	SEGMENT
_this$ = -4						; size = 4
_punk$ = 8						; size = 4
_phr$ = 12						; size = 4
??0CPersistStream@@QAE@PAUIUnknown@@PAJ@Z PROC		; CPersistStream::CPersistStream, COMDAT
; _this$ = ecx
; Line 22
	push	ebp
	mov	ebp, esp
	push	ecx
	mov	DWORD PTR [ebp-4], -858993460		; ccccccccH
	mov	DWORD PTR _this$[ebp], ecx
	mov	ecx, DWORD PTR _this$[ebp]
	call	??0IPersistStream@@QAE@XZ
	mov	eax, DWORD PTR _this$[ebp]
	mov	DWORD PTR [eax], OFFSET ??_7CPersistStream@@6B@
	mov	ecx, DWORD PTR _this$[ebp]
	mov	DWORD PTR [ecx+8], 0
; Line 23
	mov	ecx, DWORD PTR _this$[ebp]
	call	?GetSoftwareVersion@CPersistStream@@UAEKXZ ; CPersistStream::GetSoftwareVersion
	mov	edx, DWORD PTR _this$[ebp]
	mov	DWORD PTR [edx+4], eax
; Line 24
	mov	eax, DWORD PTR _this$[ebp]
	add	esp, 4
	cmp	ebp, esp
	call	__RTC_CheckEsp
	mov	esp, ebp
	pop	ebp
	ret	8
??0CPersistStream@@QAE@PAUIUnknown@@PAJ@Z ENDP		; CPersistStream::CPersistStream
; Function compile flags: /Odtp /RTCsu
_TEXT	ENDS
;	COMDAT ?IsDirty@CPersistStream@@UAGJXZ
_TEXT	SEGMENT
_this$ = 8						; size = 4
?IsDirty@CPersistStream@@UAGJXZ PROC			; CPersistStream::IsDirty, COMDAT
; File c:\downloads\mediapoint\src\filters\baseclasses\pstream.h
; Line 61
	push	ebp
	mov	ebp, esp
	mov	eax, DWORD PTR _this$[ebp]
	xor	ecx, ecx
	cmp	DWORD PTR [eax+8], 0
	sete	cl
	mov	eax, ecx
	pop	ebp
	ret	4
?IsDirty@CPersistStream@@UAGJXZ ENDP			; CPersistStream::IsDirty
; Function compile flags: /Odtp /RTCsu
_TEXT	ENDS
;	COMDAT ?GetSizeMax@CPersistStream@@UAGJPAT_ULARGE_INTEGER@@@Z
_TEXT	SEGMENT
_this$ = 8						; size = 4
_pcbSize$ = 12						; size = 4
?GetSizeMax@CPersistStream@@UAGJPAT_ULARGE_INTEGER@@@Z PROC ; CPersistStream::GetSizeMax, COMDAT
; Line 66
	push	ebp
	mov	ebp, esp
	push	esi
	mov	eax, DWORD PTR _this$[ebp]
	mov	edx, DWORD PTR [eax]
	mov	esi, esp
	mov	ecx, DWORD PTR _this$[ebp]
	mov	eax, DWORD PTR [edx+36]
	call	eax
	cmp	esi, esp
	call	__RTC_CheckEsp
	add	eax, 24					; 00000018H
	xor	ecx, ecx
	mov	edx, DWORD PTR _pcbSize$[ebp]
	mov	DWORD PTR [edx], eax
	mov	DWORD PTR [edx+4], ecx
	xor	eax, eax
	pop	esi
	cmp	ebp, esp
	call	__RTC_CheckEsp
	pop	ebp
	ret	8
?GetSizeMax@CPersistStream@@UAGJPAT_ULARGE_INTEGER@@@Z ENDP ; CPersistStream::GetSizeMax
; Function compile flags: /Odtp /RTCsu
_TEXT	ENDS
;	COMDAT ?GetSoftwareVersion@CPersistStream@@UAEKXZ
_TEXT	SEGMENT
_this$ = -4						; size = 4
?GetSoftwareVersion@CPersistStream@@UAEKXZ PROC		; CPersistStream::GetSoftwareVersion, COMDAT
; _this$ = ecx
; Line 87
	push	ebp
	mov	ebp, esp
	push	ecx
	mov	DWORD PTR [ebp-4], -858993460		; ccccccccH
	mov	DWORD PTR _this$[ebp], ecx
	xor	eax, eax
	mov	esp, ebp
	pop	ebp
	ret	0
?GetSoftwareVersion@CPersistStream@@UAEKXZ ENDP		; CPersistStream::GetSoftwareVersion
; Function compile flags: /Odtp /RTCsu
_TEXT	ENDS
;	COMDAT ?SizeMax@CPersistStream@@UAEHXZ
_TEXT	SEGMENT
_this$ = -4						; size = 4
?SizeMax@CPersistStream@@UAEHXZ PROC			; CPersistStream::SizeMax, COMDAT
; _this$ = ecx
; Line 95
	push	ebp
	mov	ebp, esp
	push	ecx
	mov	DWORD PTR [ebp-4], -858993460		; ccccccccH
	mov	DWORD PTR _this$[ebp], ecx
	xor	eax, eax
	mov	esp, ebp
	pop	ebp
	ret	0
?SizeMax@CPersistStream@@UAEHXZ ENDP			; CPersistStream::SizeMax
_TEXT	ENDS
PUBLIC	??0IPersist@@QAE@XZ				; IPersist::IPersist
; Function compile flags: /Odtp /RTCsu
;	COMDAT ??0IPersistStream@@QAE@XZ
_TEXT	SEGMENT
_this$ = -4						; size = 4
??0IPersistStream@@QAE@XZ PROC				; IPersistStream::IPersistStream, COMDAT
; _this$ = ecx
	push	ebp
	mov	ebp, esp
	push	ecx
	mov	DWORD PTR [ebp-4], -858993460		; ccccccccH
	mov	DWORD PTR _this$[ebp], ecx
	mov	ecx, DWORD PTR _this$[ebp]
	call	??0IPersist@@QAE@XZ
	mov	eax, DWORD PTR _this$[ebp]
	add	esp, 4
	cmp	ebp, esp
	call	__RTC_CheckEsp
	mov	esp, ebp
	pop	ebp
	ret	0
??0IPersistStream@@QAE@XZ ENDP				; IPersistStream::IPersistStream
_TEXT	ENDS
PUBLIC	??0IUnknown@@QAE@XZ				; IUnknown::IUnknown
; Function compile flags: /Odtp /RTCsu
;	COMDAT ??0IPersist@@QAE@XZ
_TEXT	SEGMENT
_this$ = -4						; size = 4
??0IPersist@@QAE@XZ PROC				; IPersist::IPersist, COMDAT
; _this$ = ecx
	push	ebp
	mov	ebp, esp
	push	ecx
	mov	DWORD PTR [ebp-4], -858993460		; ccccccccH
	mov	DWORD PTR _this$[ebp], ecx
	mov	ecx, DWORD PTR _this$[ebp]
	call	??0IUnknown@@QAE@XZ
	mov	eax, DWORD PTR _this$[ebp]
	add	esp, 4
	cmp	ebp, esp
	call	__RTC_CheckEsp
	mov	esp, ebp
	pop	ebp
	ret	0
??0IPersist@@QAE@XZ ENDP				; IPersist::IPersist
; Function compile flags: /Odtp /RTCsu
_TEXT	ENDS
;	COMDAT ??0IUnknown@@QAE@XZ
_TEXT	SEGMENT
_this$ = -4						; size = 4
??0IUnknown@@QAE@XZ PROC				; IUnknown::IUnknown, COMDAT
; _this$ = ecx
	push	ebp
	mov	ebp, esp
	push	ecx
	mov	DWORD PTR [ebp-4], -858993460		; ccccccccH
	mov	DWORD PTR _this$[ebp], ecx
	mov	eax, DWORD PTR _this$[ebp]
	mov	esp, ebp
	pop	ebp
	ret	0
??0IUnknown@@QAE@XZ ENDP				; IUnknown::IUnknown
_TEXT	ENDS
PUBLIC	??1CPersistStream@@QAE@XZ			; CPersistStream::~CPersistStream
; Function compile flags: /Odtp /RTCsu
;	COMDAT ??1CPersistStream@@QAE@XZ
_TEXT	SEGMENT
_this$ = -4						; size = 4
??1CPersistStream@@QAE@XZ PROC				; CPersistStream::~CPersistStream, COMDAT
; _this$ = ecx
; File c:\downloads\mediapoint\src\filters\baseclasses\pstream.cpp
; Line 30
	push	ebp
	mov	ebp, esp
	push	ecx
	mov	DWORD PTR [ebp-4], -858993460		; ccccccccH
	mov	DWORD PTR _this$[ebp], ecx
	mov	eax, DWORD PTR _this$[ebp]
	mov	DWORD PTR [eax], OFFSET ??_7CPersistStream@@6B@
; Line 32
	mov	esp, ebp
	pop	ebp
	ret	0
??1CPersistStream@@QAE@XZ ENDP				; CPersistStream::~CPersistStream
; Function compile flags: /Odtp /RTCsu
_TEXT	ENDS
;	COMDAT ?WriteToStream@CPersistStream@@UAEJPAUIStream@@@Z
_TEXT	SEGMENT
_this$ = -4						; size = 4
_pStream$ = 8						; size = 4
?WriteToStream@CPersistStream@@UAEJPAUIStream@@@Z PROC	; CPersistStream::WriteToStream, COMDAT
; _this$ = ecx
; Line 61
	push	ebp
	mov	ebp, esp
	push	ecx
	mov	DWORD PTR [ebp-4], -858993460		; ccccccccH
	mov	DWORD PTR _this$[ebp], ecx
; Line 65
	xor	eax, eax
; Line 66
	mov	esp, ebp
	pop	ebp
	ret	4
?WriteToStream@CPersistStream@@UAEJPAUIStream@@@Z ENDP	; CPersistStream::WriteToStream
; Function compile flags: /Odtp /RTCsu
_TEXT	ENDS
;	COMDAT ?ReadFromStream@CPersistStream@@UAEJPAUIStream@@@Z
_TEXT	SEGMENT
_this$ = -4						; size = 4
_pStream$ = 8						; size = 4
?ReadFromStream@CPersistStream@@UAEJPAUIStream@@@Z PROC	; CPersistStream::ReadFromStream, COMDAT
; _this$ = ecx
; Line 71
	push	ebp
	mov	ebp, esp
	push	ecx
	mov	DWORD PTR [ebp-4], -858993460		; ccccccccH
	mov	DWORD PTR _this$[ebp], ecx
; Line 75
	xor	eax, eax
; Line 76
	mov	esp, ebp
	pop	ebp
	ret	4
?ReadFromStream@CPersistStream@@UAEJPAUIStream@@@Z ENDP	; CPersistStream::ReadFromStream
_TEXT	ENDS
PUBLIC	_ReadInt@8
EXTRN	@_RTC_CheckStackVars@8:PROC
; Function compile flags: /Odtp /RTCsu
;	COMDAT ?Load@CPersistStream@@UAGJPAUIStream@@@Z
_TEXT	SEGMENT
_hr$ = -8						; size = 4
_this$ = 8						; size = 4
_pStm$ = 12						; size = 4
?Load@CPersistStream@@UAGJPAUIStream@@@Z PROC		; CPersistStream::Load, COMDAT
; Line 84
	push	ebp
	mov	ebp, esp
	sub	esp, 12					; 0000000cH
	push	esi
	mov	DWORD PTR [ebp-12], -858993460		; ccccccccH
	mov	DWORD PTR [ebp-8], -858993460		; ccccccccH
	mov	DWORD PTR [ebp-4], -858993460		; ccccccccH
; Line 87
	lea	eax, DWORD PTR _hr$[ebp]
	push	eax
	mov	ecx, DWORD PTR _pStm$[ebp]
	push	ecx
	call	_ReadInt@8
	mov	edx, DWORD PTR _this$[ebp]
	mov	DWORD PTR [edx+4], eax
; Line 88
	cmp	DWORD PTR _hr$[ebp], 0
	jge	SHORT $LN1@Load
; Line 89
	mov	eax, DWORD PTR _hr$[ebp]
	jmp	SHORT $LN2@Load
$LN1@Load:
; Line 92
	mov	esi, esp
	mov	eax, DWORD PTR _pStm$[ebp]
	push	eax
	mov	ecx, DWORD PTR _this$[ebp]
	mov	edx, DWORD PTR [ecx]
	mov	ecx, DWORD PTR _this$[ebp]
	mov	eax, DWORD PTR [edx+44]
	call	eax
	cmp	esi, esp
	call	__RTC_CheckEsp
$LN2@Load:
; Line 93
	push	edx
	mov	ecx, ebp
	push	eax
	lea	edx, DWORD PTR $LN6@Load
	call	@_RTC_CheckStackVars@8
	pop	eax
	pop	edx
	pop	esi
	add	esp, 12					; 0000000cH
	cmp	ebp, esp
	call	__RTC_CheckEsp
	mov	esp, ebp
	pop	ebp
	ret	8
	npad	2
$LN6@Load:
	DD	1
	DD	$LN5@Load
$LN5@Load:
	DD	-8					; fffffff8H
	DD	4
	DD	$LN4@Load
$LN4@Load:
	DB	104					; 00000068H
	DB	114					; 00000072H
	DB	0
?Load@CPersistStream@@UAGJPAUIStream@@@Z ENDP		; CPersistStream::Load
_TEXT	ENDS
PUBLIC	_WriteInt@8
; Function compile flags: /Odtp /RTCsu
;	COMDAT ?Save@CPersistStream@@UAGJPAUIStream@@H@Z
_TEXT	SEGMENT
_hr$ = -4						; size = 4
_this$ = 8						; size = 4
_pStm$ = 12						; size = 4
_fClearDirty$ = 16					; size = 4
?Save@CPersistStream@@UAGJPAUIStream@@H@Z PROC		; CPersistStream::Save, COMDAT
; Line 102
	push	ebp
	mov	ebp, esp
	push	ecx
	push	esi
	mov	DWORD PTR [ebp-4], -858993460		; ccccccccH
; Line 104
	mov	eax, DWORD PTR _this$[ebp]
	mov	edx, DWORD PTR [eax]
	mov	esi, esp
	mov	ecx, DWORD PTR _this$[ebp]
	mov	eax, DWORD PTR [edx+32]
	call	eax
	cmp	esi, esp
	call	__RTC_CheckEsp
	push	eax
	mov	ecx, DWORD PTR _pStm$[ebp]
	push	ecx
	call	_WriteInt@8
	mov	DWORD PTR _hr$[ebp], eax
; Line 105
	cmp	DWORD PTR _hr$[ebp], 0
	jge	SHORT $LN2@Save
; Line 106
	mov	eax, DWORD PTR _hr$[ebp]
	jmp	SHORT $LN3@Save
$LN2@Save:
; Line 109
	mov	esi, esp
	mov	edx, DWORD PTR _pStm$[ebp]
	push	edx
	mov	eax, DWORD PTR _this$[ebp]
	mov	edx, DWORD PTR [eax]
	mov	ecx, DWORD PTR _this$[ebp]
	mov	eax, DWORD PTR [edx+40]
	call	eax
	cmp	esi, esp
	call	__RTC_CheckEsp
	mov	DWORD PTR _hr$[ebp], eax
; Line 110
	cmp	DWORD PTR _hr$[ebp], 0
	jge	SHORT $LN1@Save
; Line 111
	mov	eax, DWORD PTR _hr$[ebp]
	jmp	SHORT $LN3@Save
$LN1@Save:
; Line 114
	xor	ecx, ecx
	cmp	DWORD PTR _fClearDirty$[ebp], 0
	sete	cl
	mov	edx, DWORD PTR _this$[ebp]
	mov	DWORD PTR [edx+8], ecx
; Line 116
	mov	eax, DWORD PTR _hr$[ebp]
$LN3@Save:
; Line 117
	pop	esi
	add	esp, 4
	cmp	ebp, esp
	call	__RTC_CheckEsp
	mov	esp, ebp
	pop	ebp
	ret	12					; 0000000cH
?Save@CPersistStream@@UAGJPAUIStream@@H@Z ENDP		; CPersistStream::Save
_TEXT	ENDS
PUBLIC	__$ArrayPad$
EXTRN	__imp__wsprintfW:PROC
EXTRN	___security_cookie:DWORD
EXTRN	@__security_check_cookie@4:PROC
; Function compile flags: /Odtp /RTCsu
;	COMDAT _WriteInt@8
_TEXT	SEGMENT
_Buff$ = -36						; size = 26
__$ArrayPad$ = -4					; size = 4
_pIStream$ = 8						; size = 4
_n$ = 12						; size = 4
_WriteInt@8 PROC					; COMDAT
; Line 129
	push	ebp
	mov	ebp, esp
	sub	esp, 40					; 00000028H
	push	esi
	push	edi
	lea	edi, DWORD PTR [ebp-40]
	mov	ecx, 10					; 0000000aH
	mov	eax, -858993460				; ccccccccH
	rep stosd
	mov	eax, DWORD PTR ___security_cookie
	xor	eax, ebp
	mov	DWORD PTR __$ArrayPad$[ebp], eax
; Line 131
	mov	esi, esp
	mov	eax, DWORD PTR _n$[ebp]
	push	eax
	push	OFFSET $SG81597
	lea	ecx, DWORD PTR _Buff$[ebp]
	push	ecx
	call	DWORD PTR __imp__wsprintfW
	add	esp, 12					; 0000000cH
	cmp	esi, esp
	call	__RTC_CheckEsp
; Line 132
	mov	esi, esp
	push	0
	push	24					; 00000018H
	lea	edx, DWORD PTR _Buff$[ebp]
	push	edx
	mov	eax, DWORD PTR _pIStream$[ebp]
	mov	ecx, DWORD PTR [eax]
	mov	edx, DWORD PTR _pIStream$[ebp]
	push	edx
	mov	eax, DWORD PTR [ecx+16]
	call	eax
	cmp	esi, esp
	call	__RTC_CheckEsp
; Line 133
	push	edx
	mov	ecx, ebp
	push	eax
	lea	edx, DWORD PTR $LN5@WriteInt
	call	@_RTC_CheckStackVars@8
	pop	eax
	pop	edx
	pop	edi
	pop	esi
	mov	ecx, DWORD PTR __$ArrayPad$[ebp]
	xor	ecx, ebp
	call	@__security_check_cookie@4
	add	esp, 40					; 00000028H
	cmp	ebp, esp
	call	__RTC_CheckEsp
	mov	esp, ebp
	pop	ebp
	ret	8
$LN5@WriteInt:
	DD	1
	DD	$LN4@WriteInt
$LN4@WriteInt:
	DD	-36					; ffffffdcH
	DD	26					; 0000001aH
	DD	$LN3@WriteInt
$LN3@WriteInt:
	DB	66					; 00000042H
	DB	117					; 00000075H
	DB	102					; 00000066H
	DB	102					; 00000066H
	DB	0
_WriteInt@8 ENDP
; Function compile flags: /Odtp /RTCsu
_TEXT	ENDS
;	COMDAT _ReadInt@8
_TEXT	SEGMENT
_wch$ = -16						; size = 2
_n$ = -8						; size = 4
_Sign$ = -4						; size = 4
_pIStream$ = 8						; size = 4
_hr$ = 12						; size = 4
_ReadInt@8 PROC						; COMDAT
; Line 144
	push	ebp
	mov	ebp, esp
	sub	esp, 20					; 00000014H
	push	esi
	mov	eax, -858993460				; ccccccccH
	mov	DWORD PTR [ebp-20], eax
	mov	DWORD PTR [ebp-16], eax
	mov	DWORD PTR [ebp-12], eax
	mov	DWORD PTR [ebp-8], eax
	mov	DWORD PTR [ebp-4], eax
; Line 146
	mov	DWORD PTR _Sign$[ebp], 1
; Line 147
	mov	DWORD PTR _n$[ebp], 0
; Line 150
	mov	esi, esp
	push	0
	push	2
	lea	eax, DWORD PTR _wch$[ebp]
	push	eax
	mov	ecx, DWORD PTR _pIStream$[ebp]
	mov	edx, DWORD PTR [ecx]
	mov	eax, DWORD PTR _pIStream$[ebp]
	push	eax
	mov	ecx, DWORD PTR [edx+12]
	call	ecx
	cmp	esi, esp
	call	__RTC_CheckEsp
	mov	edx, DWORD PTR _hr$[ebp]
	mov	DWORD PTR [edx], eax
; Line 151
	mov	eax, DWORD PTR _hr$[ebp]
	cmp	DWORD PTR [eax], 0
	jge	SHORT $LN13@ReadInt
; Line 152
	xor	eax, eax
	jmp	$LN14@ReadInt
$LN13@ReadInt:
; Line 155
	movzx	ecx, WORD PTR _wch$[ebp]
	cmp	ecx, 45					; 0000002dH
	jne	SHORT $LN10@ReadInt
; Line 156
	mov	DWORD PTR _Sign$[ebp], -1
; Line 157
	mov	esi, esp
	push	0
	push	2
	lea	edx, DWORD PTR _wch$[ebp]
	push	edx
	mov	eax, DWORD PTR _pIStream$[ebp]
	mov	ecx, DWORD PTR [eax]
	mov	edx, DWORD PTR _pIStream$[ebp]
	push	edx
	mov	eax, DWORD PTR [ecx+12]
	call	eax
	cmp	esi, esp
	call	__RTC_CheckEsp
	mov	ecx, DWORD PTR _hr$[ebp]
	mov	DWORD PTR [ecx], eax
; Line 158
	mov	edx, DWORD PTR _hr$[ebp]
	cmp	DWORD PTR [edx], 0
	jge	SHORT $LN10@ReadInt
; Line 159
	xor	eax, eax
	jmp	$LN14@ReadInt
$LN10@ReadInt:
; Line 164
	movzx	eax, WORD PTR _wch$[ebp]
	cmp	eax, 48					; 00000030H
	jl	SHORT $LN8@ReadInt
	movzx	ecx, WORD PTR _wch$[ebp]
	cmp	ecx, 57					; 00000039H
	jg	SHORT $LN8@ReadInt
; Line 165
	mov	edx, DWORD PTR _n$[ebp]
	imul	edx, 10					; 0000000aH
	movzx	eax, WORD PTR _wch$[ebp]
	lea	ecx, DWORD PTR [edx+eax-48]
	mov	DWORD PTR _n$[ebp], ecx
; Line 166
	jmp	SHORT $LN7@ReadInt
$LN8@ReadInt:
; Line 171
	movzx	edx, WORD PTR _wch$[ebp]
	cmp	edx, 32					; 00000020H
	je	SHORT $LN5@ReadInt
	movzx	eax, WORD PTR _wch$[ebp]
	cmp	eax, 9
	je	SHORT $LN5@ReadInt
	movzx	ecx, WORD PTR _wch$[ebp]
	cmp	ecx, 13					; 0000000dH
	je	SHORT $LN5@ReadInt
	movzx	edx, WORD PTR _wch$[ebp]
	cmp	edx, 10					; 0000000aH
	je	SHORT $LN5@ReadInt
	movzx	eax, WORD PTR _wch$[ebp]
	test	eax, eax
	jne	SHORT $LN6@ReadInt
$LN5@ReadInt:
; Line 172
	jmp	SHORT $LN9@ReadInt
; Line 173
	jmp	SHORT $LN7@ReadInt
$LN6@ReadInt:
; Line 174
	mov	ecx, DWORD PTR _hr$[ebp]
	mov	DWORD PTR [ecx], -2147220945		; 8004022fH
; Line 175
	xor	eax, eax
	jmp	SHORT $LN14@ReadInt
$LN7@ReadInt:
; Line 178
	mov	esi, esp
	push	0
	push	2
	lea	edx, DWORD PTR _wch$[ebp]
	push	edx
	mov	eax, DWORD PTR _pIStream$[ebp]
	mov	ecx, DWORD PTR [eax]
	mov	edx, DWORD PTR _pIStream$[ebp]
	push	edx
	mov	eax, DWORD PTR [ecx+12]
	call	eax
	cmp	esi, esp
	call	__RTC_CheckEsp
	mov	ecx, DWORD PTR _hr$[ebp]
	mov	DWORD PTR [ecx], eax
; Line 179
	mov	edx, DWORD PTR _hr$[ebp]
	cmp	DWORD PTR [edx], 0
	jge	SHORT $LN3@ReadInt
; Line 180
	xor	eax, eax
	jmp	SHORT $LN14@ReadInt
$LN3@ReadInt:
; Line 182
	jmp	$LN10@ReadInt
$LN9@ReadInt:
; Line 184
	cmp	DWORD PTR _n$[ebp], -2147483648		; 80000000H
	jne	SHORT $LN2@ReadInt
	cmp	DWORD PTR _Sign$[ebp], -1
	jne	SHORT $LN2@ReadInt
; Line 186
	mov	eax, DWORD PTR _n$[ebp]
	jmp	SHORT $LN14@ReadInt
	jmp	SHORT $LN14@ReadInt
$LN2@ReadInt:
; Line 188
	mov	eax, DWORD PTR _n$[ebp]
	imul	eax, DWORD PTR _Sign$[ebp]
$LN14@ReadInt:
; Line 189
	push	edx
	mov	ecx, ebp
	push	eax
	lea	edx, DWORD PTR $LN18@ReadInt
	call	@_RTC_CheckStackVars@8
	pop	eax
	pop	edx
	pop	esi
	add	esp, 20					; 00000014H
	cmp	ebp, esp
	call	__RTC_CheckEsp
	mov	esp, ebp
	pop	ebp
	ret	8
	npad	3
$LN18@ReadInt:
	DD	1
	DD	$LN17@ReadInt
$LN17@ReadInt:
	DD	-16					; fffffff0H
	DD	2
	DD	$LN16@ReadInt
$LN16@ReadInt:
	DB	119					; 00000077H
	DB	99					; 00000063H
	DB	104					; 00000068H
	DB	0
_ReadInt@8 ENDP
_TEXT	ENDS
END
