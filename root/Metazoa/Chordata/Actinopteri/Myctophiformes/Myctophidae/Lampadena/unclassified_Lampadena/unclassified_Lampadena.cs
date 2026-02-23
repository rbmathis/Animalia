using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Lampadena;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Lampadena.unclassified_Lampadena;

/// <summary>
/// Abstract class for unclassified Lampadena (no rank).
/// NCBI TaxId: 2647354
/// </summary>
public abstract class unclassified_Lampadena : Lampadena, Iunclassified_Lampadena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lampadena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647354;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lampadena";
}
