namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Sarcoglanis;

/// <summary>
/// Interface defining characteristics of Sarcoglanis (genus).
/// </summary>
public interface ISarcoglanis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
