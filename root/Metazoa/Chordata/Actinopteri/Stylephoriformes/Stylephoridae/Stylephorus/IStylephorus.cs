namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stylephoriformes.Stylephoridae.Stylephorus;

/// <summary>
/// Interface defining characteristics of Stylephorus (genus).
/// </summary>
public interface IStylephorus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
