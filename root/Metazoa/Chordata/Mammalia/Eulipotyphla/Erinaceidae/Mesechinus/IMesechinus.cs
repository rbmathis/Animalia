namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Mesechinus;

/// <summary>
/// Interface defining characteristics of Mesechinus (genus).
/// </summary>
public interface IMesechinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
