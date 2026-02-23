namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Vernaya;

/// <summary>
/// Interface defining characteristics of Vernaya (genus).
/// </summary>
public interface IVernaya
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
