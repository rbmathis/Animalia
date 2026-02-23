namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae.Baryphthengus;

/// <summary>
/// Interface defining characteristics of Baryphthengus (genus).
/// </summary>
public interface IBaryphthengus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
