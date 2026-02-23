namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Abrocomidae.Cuscomys;

/// <summary>
/// Interface defining characteristics of Cuscomys (genus).
/// </summary>
public interface ICuscomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
