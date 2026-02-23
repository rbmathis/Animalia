using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Garra;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Garra.unclassified_Garra;

/// <summary>
/// Abstract class for unclassified Garra (no rank).
/// NCBI TaxId: 2631213
/// </summary>
public abstract class unclassified_Garra : Garra, Iunclassified_Garra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Garra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631213;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Garra";
}
