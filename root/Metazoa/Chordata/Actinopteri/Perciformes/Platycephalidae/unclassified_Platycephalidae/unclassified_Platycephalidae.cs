using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.unclassified_Platycephalidae;

/// <summary>
/// Abstract class for unclassified Platycephalidae (no rank).
/// NCBI TaxId: 1781126
/// </summary>
public abstract class unclassified_Platycephalidae : Platycephalidae, Iunclassified_Platycephalidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Platycephalidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1781126;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Platycephalidae";
}
