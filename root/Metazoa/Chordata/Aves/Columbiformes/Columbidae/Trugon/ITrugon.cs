namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Trugon;

/// <summary>
/// Interface defining characteristics of Trugon (genus).
/// </summary>
public interface ITrugon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
