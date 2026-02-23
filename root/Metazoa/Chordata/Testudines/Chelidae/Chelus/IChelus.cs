namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Chelus;

/// <summary>
/// Interface defining characteristics of Chelus (genus).
/// </summary>
public interface IChelus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
