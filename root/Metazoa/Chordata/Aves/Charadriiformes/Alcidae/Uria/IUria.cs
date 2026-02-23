namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Uria;

/// <summary>
/// Interface defining characteristics of Uria (genus).
/// </summary>
public interface IUria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
