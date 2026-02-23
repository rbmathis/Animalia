namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae.Lophiomus;

/// <summary>
/// Interface defining characteristics of Lophiomus (genus).
/// </summary>
public interface ILophiomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
