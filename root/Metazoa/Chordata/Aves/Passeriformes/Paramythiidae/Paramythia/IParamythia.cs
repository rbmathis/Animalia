namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paramythiidae.Paramythia;

/// <summary>
/// Interface defining characteristics of Paramythia (genus).
/// </summary>
public interface IParamythia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
