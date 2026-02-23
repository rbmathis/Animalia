using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Pseudoblennius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Pseudoblennius.unclassified_Pseudoblennius;

/// <summary>
/// Abstract class for unclassified Pseudoblennius (no rank).
/// NCBI TaxId: 2645663
/// </summary>
public abstract class unclassified_Pseudoblennius : Pseudoblennius, Iunclassified_Pseudoblennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudoblennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645663;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudoblennius";
}
