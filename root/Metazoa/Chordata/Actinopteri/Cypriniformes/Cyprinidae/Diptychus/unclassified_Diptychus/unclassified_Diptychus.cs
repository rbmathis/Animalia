using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Diptychus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Diptychus.unclassified_Diptychus;

/// <summary>
/// Abstract class for unclassified Diptychus (no rank).
/// NCBI TaxId: 3474241
/// </summary>
public abstract class unclassified_Diptychus : Diptychus, Iunclassified_Diptychus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diptychus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3474241;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diptychus";
}
