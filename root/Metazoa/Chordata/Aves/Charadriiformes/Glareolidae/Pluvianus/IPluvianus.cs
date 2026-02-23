namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Glareolidae.Pluvianus;

/// <summary>
/// Interface defining characteristics of Pluvianus (genus).
/// </summary>
public interface IPluvianus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
