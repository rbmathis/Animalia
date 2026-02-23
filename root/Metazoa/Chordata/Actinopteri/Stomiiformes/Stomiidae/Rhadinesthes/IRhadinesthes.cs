namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Rhadinesthes;

/// <summary>
/// Interface defining characteristics of Rhadinesthes (genus).
/// </summary>
public interface IRhadinesthes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
