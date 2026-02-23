using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae.Breviceps;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae.Breviceps.unclassified_Breviceps;

/// <summary>
/// Abstract class for unclassified Breviceps (no rank).
/// NCBI TaxId: 2643571
/// </summary>
public abstract class unclassified_Breviceps : Breviceps, Iunclassified_Breviceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Breviceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643571;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Breviceps";
}
