namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bias;

/// <summary>
/// Interface defining characteristics of Bias (genus).
/// </summary>
public interface IBias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
