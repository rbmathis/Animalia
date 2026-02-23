namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Paraleptomys;

/// <summary>
/// Interface defining characteristics of Paraleptomys (genus).
/// </summary>
public interface IParaleptomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
