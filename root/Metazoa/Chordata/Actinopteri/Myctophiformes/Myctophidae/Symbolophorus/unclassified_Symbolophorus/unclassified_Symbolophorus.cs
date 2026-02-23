using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Symbolophorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Symbolophorus.unclassified_Symbolophorus;

/// <summary>
/// Abstract class for unclassified Symbolophorus (no rank).
/// NCBI TaxId: 2649992
/// </summary>
public abstract class unclassified_Symbolophorus : Symbolophorus, Iunclassified_Symbolophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Symbolophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649992;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Symbolophorus";
}
