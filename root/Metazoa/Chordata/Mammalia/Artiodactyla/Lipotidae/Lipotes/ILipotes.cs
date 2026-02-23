namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Lipotidae.Lipotes;

/// <summary>
/// Interface defining characteristics of Lipotes (genus).
/// </summary>
public interface ILipotes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
