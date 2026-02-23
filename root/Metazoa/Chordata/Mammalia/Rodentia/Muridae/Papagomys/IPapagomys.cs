namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Papagomys;

/// <summary>
/// Interface defining characteristics of Papagomys (genus).
/// </summary>
public interface IPapagomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
