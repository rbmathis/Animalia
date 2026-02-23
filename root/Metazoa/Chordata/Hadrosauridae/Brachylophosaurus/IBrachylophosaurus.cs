namespace AnimalKingdom.root.Metazoa.Chordata.Hadrosauridae.Brachylophosaurus;

/// <summary>
/// Interface defining characteristics of Brachylophosaurus (genus).
/// </summary>
public interface IBrachylophosaurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
