namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acrocephalidae.Calamonastides;

/// <summary>
/// Interface defining characteristics of Calamonastides (genus).
/// </summary>
public interface ICalamonastides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
