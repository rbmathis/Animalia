namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Centrochir;

/// <summary>
/// Interface defining characteristics of Centrochir (genus).
/// </summary>
public interface ICentrochir
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
