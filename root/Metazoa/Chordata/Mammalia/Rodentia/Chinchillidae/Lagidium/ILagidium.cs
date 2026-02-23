namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Chinchillidae.Lagidium;

/// <summary>
/// Interface defining characteristics of Lagidium (genus).
/// </summary>
public interface ILagidium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
