namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Ptaiochen;

/// <summary>
/// Interface defining characteristics of Ptaiochen (genus).
/// </summary>
public interface IPtaiochen
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
