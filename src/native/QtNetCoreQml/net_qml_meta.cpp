#include "net_qml_meta.h"

QMetaObject *metaObjectFor(GoTypeInfo *typeInfo)
{
    return NULL;
}

GoValueMetaObject::GoValueMetaObject(QObject *value, GoAddr *addr, GoTypeInfo *typeInfo)
    : value(value), addr(addr), typeInfo(typeInfo)
{
    //d->parent = static_cast<QAbstractDynamicMetaObject *>(priv->metaObject);
    *static_cast<QMetaObject *>(this) = *metaObjectFor(typeInfo);

    QObjectPrivate *objPriv = QObjectPrivate::get(value);
    objPriv->metaObject = this;
}

int GoValueMetaObject::metaCall(QMetaObject::Call c, int idx, void **a)
{
    return -1;
}

void GoValueMetaObject::activatePropIndex(int propIndex)
{
    // Properties are added first, so the first fieldLen methods are in
    // fact the signals of the respective properties.
    int relativeIndex = propIndex - propertyOffset();
    activate(value, methodOffset() + relativeIndex, 0);
}
