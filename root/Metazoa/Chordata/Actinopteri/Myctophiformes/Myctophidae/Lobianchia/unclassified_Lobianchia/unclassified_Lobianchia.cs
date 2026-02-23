using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Lobianchia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Lobianchia.unclassified_Lobianchia;

/// <summary>
/// Abstract class for unclassified Lobianchia (no rank).
/// NCBI TaxId: 2627451
/// </summary>
public abstract class unclassified_Lobianchia : Lobianchia, Iunclassified_Lobianchia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lobianchia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627451;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lobianchia";
}
