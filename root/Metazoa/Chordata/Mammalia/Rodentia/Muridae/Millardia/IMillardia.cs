namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Millardia;

/// <summary>
/// Interface defining characteristics of Millardia (genus).
/// </summary>
public interface IMillardia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
