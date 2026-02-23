using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae.Leptopelis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae.Leptopelis.unclassified_Leptopelis;

/// <summary>
/// Abstract class for unclassified Leptopelis (no rank).
/// NCBI TaxId: 2630979
/// </summary>
public abstract class unclassified_Leptopelis : Leptopelis, Iunclassified_Leptopelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptopelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630979;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptopelis";
}
