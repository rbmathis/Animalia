namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Strix;

/// <summary>
/// Interface defining characteristics of Strix (genus).
/// </summary>
public interface IStrix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
