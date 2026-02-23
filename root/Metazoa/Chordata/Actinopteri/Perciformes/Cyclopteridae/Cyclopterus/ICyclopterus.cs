namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae.Cyclopterus;

/// <summary>
/// Interface defining characteristics of Cyclopterus (genus).
/// </summary>
public interface ICyclopterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
