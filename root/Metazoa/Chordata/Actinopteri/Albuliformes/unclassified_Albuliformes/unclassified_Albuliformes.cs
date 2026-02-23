using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Albuliformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Albuliformes.unclassified_Albuliformes;

/// <summary>
/// Abstract class for unclassified Albuliformes (no rank).
/// NCBI TaxId: 725922
/// </summary>
public abstract class unclassified_Albuliformes : Albuliformes, Iunclassified_Albuliformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Albuliformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 725922;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Albuliformes";
}
