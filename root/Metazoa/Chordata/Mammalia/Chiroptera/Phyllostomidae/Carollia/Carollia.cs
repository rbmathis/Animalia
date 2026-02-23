using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Carollia;

/// <summary>
/// Abstract class for Carollia (genus).
/// NCBI TaxId: 40232
/// </summary>
public abstract class Carollia : Phyllostomidae, ICarollia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carollia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40232;

    /// <inheritdoc />
    public virtual string GenusName => "Carollia";

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
