namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Pedionomidae.Pedionomus;

/// <summary>
/// Interface defining characteristics of Pedionomus (genus).
/// </summary>
public interface IPedionomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
