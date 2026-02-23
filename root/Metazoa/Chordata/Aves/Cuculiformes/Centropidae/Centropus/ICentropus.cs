namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Centropidae.Centropus;

/// <summary>
/// Interface defining characteristics of Centropus (genus).
/// </summary>
public interface ICentropus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
