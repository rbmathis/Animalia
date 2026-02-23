namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Euclichthyidae.Euclichthys;

/// <summary>
/// Interface defining characteristics of Euclichthys (genus).
/// </summary>
public interface IEuclichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
