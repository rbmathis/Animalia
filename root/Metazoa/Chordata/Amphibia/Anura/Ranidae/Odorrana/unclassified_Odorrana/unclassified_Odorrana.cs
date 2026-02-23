using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Odorrana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Odorrana.unclassified_Odorrana;

/// <summary>
/// Abstract class for unclassified Odorrana (no rank).
/// NCBI TaxId: 2626220
/// </summary>
public abstract class unclassified_Odorrana : Odorrana, Iunclassified_Odorrana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Odorrana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626220;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Odorrana";
}
