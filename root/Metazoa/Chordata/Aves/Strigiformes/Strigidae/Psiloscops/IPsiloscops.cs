namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Psiloscops;

/// <summary>
/// Interface defining characteristics of Psiloscops (genus).
/// </summary>
public interface IPsiloscops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
