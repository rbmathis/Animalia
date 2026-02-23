namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Heterophotus;

/// <summary>
/// Interface defining characteristics of Heterophotus (genus).
/// </summary>
public interface IHeterophotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
