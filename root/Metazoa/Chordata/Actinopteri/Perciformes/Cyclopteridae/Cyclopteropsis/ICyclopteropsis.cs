namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae.Cyclopteropsis;

/// <summary>
/// Interface defining characteristics of Cyclopteropsis (genus).
/// </summary>
public interface ICyclopteropsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
