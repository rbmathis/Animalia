using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Benthosema;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Benthosema.unclassified_Benthosema;

/// <summary>
/// Abstract class for unclassified Benthosema (no rank).
/// NCBI TaxId: 2635526
/// </summary>
public abstract class unclassified_Benthosema : Benthosema, Iunclassified_Benthosema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Benthosema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635526;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Benthosema";
}
