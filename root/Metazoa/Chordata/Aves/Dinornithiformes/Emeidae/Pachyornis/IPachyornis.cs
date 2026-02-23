namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Emeidae.Pachyornis;

/// <summary>
/// Interface defining characteristics of Pachyornis (genus).
/// </summary>
public interface IPachyornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
