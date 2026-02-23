namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Notopteridae.Notopterus;

/// <summary>
/// Interface defining characteristics of Notopterus (genus).
/// </summary>
public interface INotopterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
