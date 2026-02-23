namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Nesoenas;

/// <summary>
/// Interface defining characteristics of Nesoenas (genus).
/// </summary>
public interface INesoenas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
