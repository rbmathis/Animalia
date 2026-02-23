namespace AnimalKingdom.root.Metazoa.Chordata.Tyrannosauridae.Tyrannosaurus;

/// <summary>
/// Interface defining characteristics of Tyrannosaurus (genus).
/// </summary>
public interface ITyrannosaurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
