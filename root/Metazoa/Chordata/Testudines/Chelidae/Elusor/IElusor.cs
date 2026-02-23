namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Elusor;

/// <summary>
/// Interface defining characteristics of Elusor (genus).
/// </summary>
public interface IElusor
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
