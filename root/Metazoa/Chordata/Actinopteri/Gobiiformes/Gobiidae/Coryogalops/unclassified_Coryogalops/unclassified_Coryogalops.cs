using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Coryogalops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Coryogalops.unclassified_Coryogalops;

/// <summary>
/// Abstract class for unclassified Coryogalops (no rank).
/// NCBI TaxId: 2619589
/// </summary>
public abstract class unclassified_Coryogalops : Coryogalops, Iunclassified_Coryogalops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Coryogalops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619589;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Coryogalops";
}
