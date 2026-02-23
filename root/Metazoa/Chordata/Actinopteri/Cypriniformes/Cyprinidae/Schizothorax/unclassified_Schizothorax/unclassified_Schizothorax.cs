using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Schizothorax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Schizothorax.unclassified_Schizothorax;

/// <summary>
/// Abstract class for unclassified Schizothorax (no rank).
/// NCBI TaxId: 2624579
/// </summary>
public abstract class unclassified_Schizothorax : Schizothorax, Iunclassified_Schizothorax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Schizothorax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624579;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Schizothorax";
}
