namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Leptochariidae.Leptocharias;

/// <summary>
/// Interface defining characteristics of Leptocharias (genus).
/// </summary>
public interface ILeptocharias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
