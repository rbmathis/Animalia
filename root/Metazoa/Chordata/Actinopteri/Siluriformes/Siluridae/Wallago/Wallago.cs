using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Wallago;

/// <summary>
/// Abstract class for Wallago (genus).
/// NCBI TaxId: 36717
/// </summary>
public abstract class Wallago : Siluridae, IWallago
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Wallago";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36717;

    /// <inheritdoc />
    public virtual string GenusName => "Wallago";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
