using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Manouria;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Manouria.unclassified_Manouria;

/// <summary>
/// Abstract class for unclassified Manouria (no rank).
/// NCBI TaxId: 2625179
/// </summary>
public abstract class unclassified_Manouria : Manouria, Iunclassified_Manouria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Manouria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625179;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Manouria";
}
