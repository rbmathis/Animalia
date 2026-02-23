using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.Sargocentron;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.Sargocentron.unclassified_Sargocentron;

/// <summary>
/// Abstract class for unclassified Sargocentron (no rank).
/// NCBI TaxId: 2623333
/// </summary>
public abstract class unclassified_Sargocentron : Sargocentron, Iunclassified_Sargocentron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sargocentron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623333;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sargocentron";
}
