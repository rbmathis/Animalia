namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Lepidocharax;

/// <summary>
/// Interface defining characteristics of Lepidocharax (genus).
/// </summary>
public interface ILepidocharax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
