using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Choeroniscus;

/// <summary>
/// Abstract class for Choeroniscus (genus).
/// NCBI TaxId: 148042
/// </summary>
public abstract class Choeroniscus : Phyllostomidae, IChoeroniscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Choeroniscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148042;

    /// <inheritdoc />
    public virtual string GenusName => "Choeroniscus";

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
