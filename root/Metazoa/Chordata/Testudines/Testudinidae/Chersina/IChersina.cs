namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chersina;

/// <summary>
/// Interface defining characteristics of Chersina (genus).
/// </summary>
public interface IChersina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
