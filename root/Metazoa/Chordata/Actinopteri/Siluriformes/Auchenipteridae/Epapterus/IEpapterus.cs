namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Epapterus;

/// <summary>
/// Interface defining characteristics of Epapterus (genus).
/// </summary>
public interface IEpapterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
