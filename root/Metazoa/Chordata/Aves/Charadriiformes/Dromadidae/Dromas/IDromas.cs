namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Dromadidae.Dromas;

/// <summary>
/// Interface defining characteristics of Dromas (genus).
/// </summary>
public interface IDromas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
