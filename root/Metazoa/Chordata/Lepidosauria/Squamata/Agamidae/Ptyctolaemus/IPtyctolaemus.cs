namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Ptyctolaemus;

/// <summary>
/// Interface defining characteristics of Ptyctolaemus (genus).
/// </summary>
public interface IPtyctolaemus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
