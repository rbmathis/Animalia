namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Phalacrocoracidae.Phalacrocorax;

/// <summary>
/// Interface defining characteristics of Phalacrocorax (genus).
/// </summary>
public interface IPhalacrocorax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
