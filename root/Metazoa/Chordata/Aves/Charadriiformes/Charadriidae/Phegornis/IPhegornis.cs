namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Phegornis;

/// <summary>
/// Interface defining characteristics of Phegornis (genus).
/// </summary>
public interface IPhegornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
