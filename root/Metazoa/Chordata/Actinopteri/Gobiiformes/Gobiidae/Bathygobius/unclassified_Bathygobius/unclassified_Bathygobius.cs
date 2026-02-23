using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Bathygobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Bathygobius.unclassified_Bathygobius;

/// <summary>
/// Abstract class for unclassified Bathygobius (no rank).
/// NCBI TaxId: 2629181
/// </summary>
public abstract class unclassified_Bathygobius : Bathygobius, Iunclassified_Bathygobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathygobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629181;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathygobius";
}
