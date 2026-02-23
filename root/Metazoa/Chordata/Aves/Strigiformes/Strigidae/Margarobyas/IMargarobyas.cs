namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Margarobyas;

/// <summary>
/// Interface defining characteristics of Margarobyas (genus).
/// </summary>
public interface IMargarobyas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
