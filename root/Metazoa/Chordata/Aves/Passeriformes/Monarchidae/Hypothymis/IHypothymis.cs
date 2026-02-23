namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Hypothymis;

/// <summary>
/// Interface defining characteristics of Hypothymis (genus).
/// </summary>
public interface IHypothymis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
