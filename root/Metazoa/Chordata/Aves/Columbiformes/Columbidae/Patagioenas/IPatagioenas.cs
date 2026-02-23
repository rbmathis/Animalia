namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Patagioenas;

/// <summary>
/// Interface defining characteristics of Patagioenas (genus).
/// </summary>
public interface IPatagioenas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
