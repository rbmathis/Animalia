using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Chaenophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Chaenophryne.unclassified_Chaenophryne;

/// <summary>
/// Abstract class for unclassified Chaenophryne (no rank).
/// NCBI TaxId: 2676823
/// </summary>
public abstract class unclassified_Chaenophryne : Chaenophryne, Iunclassified_Chaenophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chaenophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2676823;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chaenophryne";
}
