using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Encrasicholina;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Encrasicholina.unclassified_Encrasicholina;

/// <summary>
/// Abstract class for unclassified Encrasicholina (no rank).
/// NCBI TaxId: 2645954
/// </summary>
public abstract class unclassified_Encrasicholina : Encrasicholina, Iunclassified_Encrasicholina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Encrasicholina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645954;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Encrasicholina";
}
