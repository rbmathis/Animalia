namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Recurvirostridae.Cladorhynchus;

/// <summary>
/// Interface defining characteristics of Cladorhynchus (genus).
/// </summary>
public interface ICladorhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
