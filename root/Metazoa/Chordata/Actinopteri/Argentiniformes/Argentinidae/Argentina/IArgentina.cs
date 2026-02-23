namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Argentinidae.Argentina;

/// <summary>
/// Interface defining characteristics of Argentina (genus).
/// </summary>
public interface IArgentina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
