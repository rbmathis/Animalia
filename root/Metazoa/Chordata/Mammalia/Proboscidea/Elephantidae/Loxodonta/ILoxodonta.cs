namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Loxodonta;

/// <summary>
/// Interface defining characteristics of Loxodonta (genus).
/// </summary>
public interface ILoxodonta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
