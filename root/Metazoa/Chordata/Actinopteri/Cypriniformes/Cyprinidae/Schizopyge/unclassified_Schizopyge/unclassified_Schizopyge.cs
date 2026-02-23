using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Schizopyge;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Schizopyge.unclassified_Schizopyge;

/// <summary>
/// Abstract class for unclassified Schizopyge (no rank).
/// NCBI TaxId: 2905707
/// </summary>
public abstract class unclassified_Schizopyge : Schizopyge, Iunclassified_Schizopyge
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Schizopyge";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2905707;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Schizopyge";
}
