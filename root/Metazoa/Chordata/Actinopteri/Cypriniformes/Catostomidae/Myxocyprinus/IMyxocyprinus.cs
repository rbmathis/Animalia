namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Myxocyprinus;

/// <summary>
/// Interface defining characteristics of Myxocyprinus (genus).
/// </summary>
public interface IMyxocyprinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
