using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Austrobatrachus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Austrobatrachus.unclassified_Austrobatrachus;

/// <summary>
/// Abstract class for unclassified Austrobatrachus (no rank).
/// NCBI TaxId: 2647159
/// </summary>
public abstract class unclassified_Austrobatrachus : Austrobatrachus, Iunclassified_Austrobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Austrobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647159;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Austrobatrachus";
}
