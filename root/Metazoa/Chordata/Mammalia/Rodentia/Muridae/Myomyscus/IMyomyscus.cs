namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Myomyscus;

/// <summary>
/// Interface defining characteristics of Myomyscus (genus).
/// </summary>
public interface IMyomyscus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
