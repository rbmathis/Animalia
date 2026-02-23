namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae.Momotus;

/// <summary>
/// Interface defining characteristics of Momotus (genus).
/// </summary>
public interface IMomotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
