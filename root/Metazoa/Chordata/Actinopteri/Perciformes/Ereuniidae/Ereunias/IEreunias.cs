namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Ereuniidae.Ereunias;

/// <summary>
/// Interface defining characteristics of Ereunias (genus).
/// </summary>
public interface IEreunias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
