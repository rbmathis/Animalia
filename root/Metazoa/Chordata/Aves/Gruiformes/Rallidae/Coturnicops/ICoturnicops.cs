namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Coturnicops;

/// <summary>
/// Interface defining characteristics of Coturnicops (genus).
/// </summary>
public interface ICoturnicops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
