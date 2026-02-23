namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Pulsatrix;

/// <summary>
/// Interface defining characteristics of Pulsatrix (genus).
/// </summary>
public interface IPulsatrix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
