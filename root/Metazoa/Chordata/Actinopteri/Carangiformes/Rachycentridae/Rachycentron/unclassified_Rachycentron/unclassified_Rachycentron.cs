using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Rachycentridae.Rachycentron;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Rachycentridae.Rachycentron.unclassified_Rachycentron;

/// <summary>
/// Abstract class for unclassified Rachycentron (no rank).
/// NCBI TaxId: 2620007
/// </summary>
public abstract class unclassified_Rachycentron : Rachycentron, Iunclassified_Rachycentron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rachycentron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620007;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rachycentron";
}
