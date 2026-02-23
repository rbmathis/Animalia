namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hyliotidae.Hyliota;

/// <summary>
/// Interface defining characteristics of Hyliota (genus).
/// </summary>
public interface IHyliota
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
