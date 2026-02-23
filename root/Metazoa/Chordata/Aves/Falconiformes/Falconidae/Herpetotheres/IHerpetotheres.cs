namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Herpetotheres;

/// <summary>
/// Interface defining characteristics of Herpetotheres (genus).
/// </summary>
public interface IHerpetotheres
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
