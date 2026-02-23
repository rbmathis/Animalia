using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Arielulus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Arielulus.unclassified_Arielulus;

/// <summary>
/// Abstract class for unclassified Arielulus (no rank).
/// NCBI TaxId: 2648285
/// </summary>
public abstract class unclassified_Arielulus : Arielulus, Iunclassified_Arielulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Arielulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648285;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Arielulus";
}
