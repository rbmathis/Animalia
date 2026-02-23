namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Actenoides;

/// <summary>
/// Interface defining characteristics of Actenoides (genus).
/// </summary>
public interface IActenoides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
