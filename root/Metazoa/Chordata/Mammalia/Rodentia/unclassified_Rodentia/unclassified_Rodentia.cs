using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.unclassified_Rodentia;

/// <summary>
/// Abstract class for unclassified Rodentia (no rank).
/// NCBI TaxId: 69157
/// </summary>
public abstract class unclassified_Rodentia : Rodentia, Iunclassified_Rodentia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rodentia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69157;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rodentia";
}
