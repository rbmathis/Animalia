namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cuniculidae.Cuniculus;

/// <summary>
/// Interface defining characteristics of Cuniculus (genus).
/// </summary>
public interface ICuniculus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
