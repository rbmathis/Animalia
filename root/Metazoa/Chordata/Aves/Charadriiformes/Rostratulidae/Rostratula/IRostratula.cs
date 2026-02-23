namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Rostratulidae.Rostratula;

/// <summary>
/// Interface defining characteristics of Rostratula (genus).
/// </summary>
public interface IRostratula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
