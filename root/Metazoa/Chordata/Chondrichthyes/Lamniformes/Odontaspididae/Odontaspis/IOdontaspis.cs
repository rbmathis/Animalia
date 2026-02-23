namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Odontaspididae.Odontaspis;

/// <summary>
/// Interface defining characteristics of Odontaspis (genus).
/// </summary>
public interface IOdontaspis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
