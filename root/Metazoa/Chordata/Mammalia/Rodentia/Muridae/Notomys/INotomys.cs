namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Notomys;

/// <summary>
/// Interface defining characteristics of Notomys (genus).
/// </summary>
public interface INotomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
