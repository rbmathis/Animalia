using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Bathyprion;

/// <summary>
/// Abstract class for Bathyprion (genus).
/// NCBI TaxId: 443630
/// </summary>
public abstract class Bathyprion : Alepocephalidae, IBathyprion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathyprion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443630;

    /// <inheritdoc />
    public virtual string GenusName => "Bathyprion";

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
