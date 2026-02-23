namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Halosauridae.Halosauropsis;

/// <summary>
/// Interface defining characteristics of Halosauropsis (genus).
/// </summary>
public interface IHalosauropsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
