using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Vampyressa;

/// <summary>
/// Abstract class for Vampyressa (genus).
/// NCBI TaxId: 148031
/// </summary>
public abstract class Vampyressa : Phyllostomidae, IVampyressa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vampyressa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148031;

    /// <inheritdoc />
    public virtual string GenusName => "Vampyressa";

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
