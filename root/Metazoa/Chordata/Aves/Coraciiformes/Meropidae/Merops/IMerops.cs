namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Meropidae.Merops;

/// <summary>
/// Interface defining characteristics of Merops (genus).
/// </summary>
public interface IMerops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
