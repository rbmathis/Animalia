namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Caracara;

/// <summary>
/// Interface defining characteristics of Caracara (genus).
/// </summary>
public interface ICaracara
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
