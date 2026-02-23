namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Entomocorus;

/// <summary>
/// Interface defining characteristics of Entomocorus (genus).
/// </summary>
public interface IEntomocorus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
