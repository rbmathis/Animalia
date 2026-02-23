namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Henicophaps;

/// <summary>
/// Interface defining characteristics of Henicophaps (genus).
/// </summary>
public interface IHenicophaps
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
