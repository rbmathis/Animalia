namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Choerophryne;

/// <summary>
/// Interface defining characteristics of Choerophryne (genus).
/// </summary>
public interface IChoerophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
