namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Thylacinidae.Thylacinus;

/// <summary>
/// Interface defining characteristics of Thylacinus (genus).
/// </summary>
public interface IThylacinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
