using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Liopholidophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Liopholidophis.unclassified_Liopholidophis;

/// <summary>
/// Abstract class for unclassified Liopholidophis (no rank).
/// NCBI TaxId: 2638857
/// </summary>
public abstract class unclassified_Liopholidophis : Liopholidophis, Iunclassified_Liopholidophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Liopholidophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638857;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Liopholidophis";
}
