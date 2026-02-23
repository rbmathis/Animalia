using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Bolitoglossa;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Bolitoglossa.unclassified_Bolitoglossa;

/// <summary>
/// Abstract class for unclassified Bolitoglossa (no rank).
/// NCBI TaxId: 3406864
/// </summary>
public abstract class unclassified_Bolitoglossa : Bolitoglossa, Iunclassified_Bolitoglossa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bolitoglossa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3406864;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bolitoglossa";
}
