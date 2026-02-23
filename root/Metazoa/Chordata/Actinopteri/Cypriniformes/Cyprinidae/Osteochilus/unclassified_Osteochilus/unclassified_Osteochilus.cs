using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Osteochilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Osteochilus.unclassified_Osteochilus;

/// <summary>
/// Abstract class for unclassified Osteochilus (no rank).
/// NCBI TaxId: 2640543
/// </summary>
public abstract class unclassified_Osteochilus : Osteochilus, Iunclassified_Osteochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Osteochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640543;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Osteochilus";
}
