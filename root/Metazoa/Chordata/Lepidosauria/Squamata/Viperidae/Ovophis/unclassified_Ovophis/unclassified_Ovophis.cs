using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Ovophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Ovophis.unclassified_Ovophis;

/// <summary>
/// Abstract class for unclassified Ovophis (no rank).
/// NCBI TaxId: 3027201
/// </summary>
public abstract class unclassified_Ovophis : Ovophis, Iunclassified_Ovophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ovophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3027201;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ovophis";
}
