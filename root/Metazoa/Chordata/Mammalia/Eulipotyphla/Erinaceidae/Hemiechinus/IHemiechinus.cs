namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Hemiechinus;

/// <summary>
/// Interface defining characteristics of Hemiechinus (genus).
/// </summary>
public interface IHemiechinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
