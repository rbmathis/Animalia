namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Lotidae.Ciliata;

/// <summary>
/// Interface defining characteristics of Ciliata (genus).
/// </summary>
public interface ICiliata
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
