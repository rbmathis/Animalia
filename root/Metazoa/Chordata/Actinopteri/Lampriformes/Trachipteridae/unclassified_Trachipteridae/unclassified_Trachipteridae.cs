using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Trachipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Trachipteridae.unclassified_Trachipteridae;

/// <summary>
/// Abstract class for unclassified Trachipteridae (no rank).
/// NCBI TaxId: 2726661
/// </summary>
public abstract class unclassified_Trachipteridae : Trachipteridae, Iunclassified_Trachipteridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachipteridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726661;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachipteridae";
}
