namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Carchariidae.Carcharias;

/// <summary>
/// Interface defining characteristics of Carcharias (genus).
/// </summary>
public interface ICarcharias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
