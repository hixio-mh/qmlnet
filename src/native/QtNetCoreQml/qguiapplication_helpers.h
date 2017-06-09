#ifndef QGUIAPPLICATION_HELPERS_H
#define QGUIAPPLICATION_HELPERS_H

#include "qtnetcoreqml_global.h"
#include <QGuiApplication>
#include <QQmlApplicationEngine>
#include <vector>
#include <string>
#include <QDateTime>

class Message : public QObject
{
    Q_OBJECT
    Q_PROPERTY(QString author READ author WRITE setAuthor)
    Q_PROPERTY(QDateTime creationDate READ creationDate WRITE setCreationDate)
public:
    QString author() const { return m_author; }
    void setAuthor(QString newAuthor)
    {
        m_author = newAuthor;
    }
    QDateTime creationDate() const { return m_creationDate; }
    void setCreationDate(QDateTime newCreationDate)
    {
        m_creationDate = newCreationDate;
    }

private:
    QString m_author;
    QDateTime m_creationDate;
};

extern "C" {
QGuiApplication* new_QGuiApplication(std::vector<std::string> argv);

void QQmlApplicationEngine_loadFile(QQmlApplicationEngine* instance, std::string filePath);

}
#endif // QGUIAPPLICATION_HELPERS_H
