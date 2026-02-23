namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lepidiolamprologus;

/// <summary>
/// Interface defining characteristics of Lepidiolamprologus (genus).
/// </summary>
public interface ILepidiolamprologus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
