namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Chinchillidae.Lagostomus;

/// <summary>
/// Interface defining characteristics of Lagostomus (genus).
/// </summary>
public interface ILagostomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
