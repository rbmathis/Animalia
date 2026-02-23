namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Picoides;

/// <summary>
/// Interface defining characteristics of Picoides (genus).
/// </summary>
public interface IPicoides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
