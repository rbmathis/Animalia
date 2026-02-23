namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Neomorphidae.Neomorphus;

/// <summary>
/// Interface defining characteristics of Neomorphus (genus).
/// </summary>
public interface INeomorphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
