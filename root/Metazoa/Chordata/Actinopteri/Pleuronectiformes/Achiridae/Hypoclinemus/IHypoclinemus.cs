namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae.Hypoclinemus;

/// <summary>
/// Interface defining characteristics of Hypoclinemus (genus).
/// </summary>
public interface IHypoclinemus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
