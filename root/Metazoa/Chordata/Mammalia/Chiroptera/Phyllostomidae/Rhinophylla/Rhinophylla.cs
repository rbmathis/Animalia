using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Rhinophylla;

/// <summary>
/// Abstract class for Rhinophylla (genus).
/// NCBI TaxId: 138698
/// </summary>
public abstract class Rhinophylla : Phyllostomidae, IRhinophylla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinophylla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 138698;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinophylla";

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
