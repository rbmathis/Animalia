namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Picumnus;

/// <summary>
/// Interface defining characteristics of Picumnus (genus).
/// </summary>
public interface IPicumnus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
