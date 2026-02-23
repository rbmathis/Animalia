namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Pardipicus;

/// <summary>
/// Interface defining characteristics of Pardipicus (genus).
/// </summary>
public interface IPardipicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
