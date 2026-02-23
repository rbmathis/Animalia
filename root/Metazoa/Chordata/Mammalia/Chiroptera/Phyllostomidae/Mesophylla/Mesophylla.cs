using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Mesophylla;

/// <summary>
/// Abstract class for Mesophylla (genus).
/// NCBI TaxId: 148026
/// </summary>
public abstract class Mesophylla : Phyllostomidae, IMesophylla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesophylla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148026;

    /// <inheritdoc />
    public virtual string GenusName => "Mesophylla";

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
