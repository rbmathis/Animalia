namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Gymnasio;

/// <summary>
/// Interface defining characteristics of Gymnasio (genus).
/// </summary>
public interface IGymnasio
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
