namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Treron;

/// <summary>
/// Interface defining characteristics of Treron (genus).
/// </summary>
public interface ITreron
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
