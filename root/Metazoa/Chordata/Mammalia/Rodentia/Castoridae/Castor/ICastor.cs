namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Castoridae.Castor;

/// <summary>
/// Interface defining characteristics of Castor (genus).
/// </summary>
public interface ICastor
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
