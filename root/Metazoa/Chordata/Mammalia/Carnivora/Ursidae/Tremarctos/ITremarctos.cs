namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Tremarctos;

/// <summary>
/// Interface defining characteristics of Tremarctos (genus).
/// </summary>
public interface ITremarctos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
