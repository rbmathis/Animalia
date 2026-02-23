using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Ctenogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Ctenogobius.unclassified_Ctenogobius;

/// <summary>
/// Abstract class for unclassified Ctenogobius (no rank).
/// NCBI TaxId: 2639528
/// </summary>
public abstract class unclassified_Ctenogobius : Ctenogobius, Iunclassified_Ctenogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ctenogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639528;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ctenogobius";
}
