namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliopsidae.Doliolula;

/// <summary>
/// Interface defining characteristics of Doliolula (genus).
/// </summary>
public interface IDoliolula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
