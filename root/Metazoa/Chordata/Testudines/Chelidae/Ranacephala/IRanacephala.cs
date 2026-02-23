namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Ranacephala;

/// <summary>
/// Interface defining characteristics of Ranacephala (genus).
/// </summary>
public interface IRanacephala
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
