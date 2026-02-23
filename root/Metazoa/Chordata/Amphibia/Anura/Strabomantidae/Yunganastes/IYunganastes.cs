namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Yunganastes;

/// <summary>
/// Interface defining characteristics of Yunganastes (genus).
/// </summary>
public interface IYunganastes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
