namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Hydromedusa;

/// <summary>
/// Interface defining characteristics of Hydromedusa (genus).
/// </summary>
public interface IHydromedusa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
