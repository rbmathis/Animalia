namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Thinornis;

/// <summary>
/// Interface defining characteristics of Thinornis (genus).
/// </summary>
public interface IThinornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
