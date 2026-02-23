namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluriformes_incertae_sedis.Kryptoglanidae.Kryptoglanis;

/// <summary>
/// Interface defining characteristics of Kryptoglanis (genus).
/// </summary>
public interface IKryptoglanis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
