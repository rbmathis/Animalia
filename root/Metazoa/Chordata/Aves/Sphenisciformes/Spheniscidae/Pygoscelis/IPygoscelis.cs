namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Pygoscelis;

/// <summary>
/// Interface defining characteristics of Pygoscelis (genus).
/// </summary>
public interface IPygoscelis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
