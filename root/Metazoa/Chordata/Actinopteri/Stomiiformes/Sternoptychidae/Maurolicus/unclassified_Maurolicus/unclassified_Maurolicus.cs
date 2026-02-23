using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Maurolicus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Maurolicus.unclassified_Maurolicus;

/// <summary>
/// Abstract class for unclassified Maurolicus (no rank).
/// NCBI TaxId: 2641819
/// </summary>
public abstract class unclassified_Maurolicus : Maurolicus, Iunclassified_Maurolicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Maurolicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641819;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Maurolicus";
}
