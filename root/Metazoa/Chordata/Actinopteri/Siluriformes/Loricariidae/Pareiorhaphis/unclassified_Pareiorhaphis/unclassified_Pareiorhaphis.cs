using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pareiorhaphis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pareiorhaphis.unclassified_Pareiorhaphis;

/// <summary>
/// Abstract class for unclassified Pareiorhaphis (no rank).
/// NCBI TaxId: 2623277
/// </summary>
public abstract class unclassified_Pareiorhaphis : Pareiorhaphis, Iunclassified_Pareiorhaphis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pareiorhaphis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623277;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pareiorhaphis";
}
