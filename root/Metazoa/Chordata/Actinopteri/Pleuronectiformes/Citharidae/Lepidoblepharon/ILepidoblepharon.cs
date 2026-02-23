namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Citharidae.Lepidoblepharon;

/// <summary>
/// Interface defining characteristics of Lepidoblepharon (genus).
/// </summary>
public interface ILepidoblepharon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
