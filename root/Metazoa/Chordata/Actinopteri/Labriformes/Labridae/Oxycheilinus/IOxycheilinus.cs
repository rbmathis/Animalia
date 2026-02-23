namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Oxycheilinus;

/// <summary>
/// Interface defining characteristics of Oxycheilinus (genus).
/// </summary>
public interface IOxycheilinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
