using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Phoxinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Phoxinus.unclassified_Phoxinus;

/// <summary>
/// Abstract class for unclassified Phoxinus (no rank).
/// NCBI TaxId: 2645499
/// </summary>
public abstract class unclassified_Phoxinus : Phoxinus, Iunclassified_Phoxinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phoxinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645499;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phoxinus";
}
