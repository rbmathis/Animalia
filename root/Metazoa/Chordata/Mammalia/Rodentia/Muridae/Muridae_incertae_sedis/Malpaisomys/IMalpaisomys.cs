namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Muridae_incertae_sedis.Malpaisomys;

/// <summary>
/// Interface defining characteristics of Malpaisomys (genus).
/// </summary>
public interface IMalpaisomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
