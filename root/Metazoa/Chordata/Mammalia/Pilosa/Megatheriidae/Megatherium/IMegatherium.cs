namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Megatheriidae.Megatherium;

/// <summary>
/// Interface defining characteristics of Megatherium (genus).
/// </summary>
public interface IMegatherium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
