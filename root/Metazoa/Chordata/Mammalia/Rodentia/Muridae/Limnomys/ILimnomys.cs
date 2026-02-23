namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Limnomys;

/// <summary>
/// Interface defining characteristics of Limnomys (genus).
/// </summary>
public interface ILimnomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
