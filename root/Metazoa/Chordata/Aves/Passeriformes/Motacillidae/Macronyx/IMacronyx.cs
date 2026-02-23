namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae.Macronyx;

/// <summary>
/// Interface defining characteristics of Macronyx (genus).
/// </summary>
public interface IMacronyx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
