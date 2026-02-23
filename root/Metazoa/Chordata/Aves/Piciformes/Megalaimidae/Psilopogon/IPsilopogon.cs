namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Megalaimidae.Psilopogon;

/// <summary>
/// Interface defining characteristics of Psilopogon (genus).
/// </summary>
public interface IPsilopogon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
