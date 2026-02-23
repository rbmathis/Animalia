namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Cycloramphidae.Thoropa;

/// <summary>
/// Interface defining characteristics of Thoropa (genus).
/// </summary>
public interface IThoropa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
