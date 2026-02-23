namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Parapistocalamus;

/// <summary>
/// Interface defining characteristics of Parapistocalamus (genus).
/// </summary>
public interface IParapistocalamus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
