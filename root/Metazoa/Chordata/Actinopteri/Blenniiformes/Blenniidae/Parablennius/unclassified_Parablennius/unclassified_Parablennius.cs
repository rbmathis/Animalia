using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Parablennius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Parablennius.unclassified_Parablennius;

/// <summary>
/// Abstract class for unclassified Parablennius (no rank).
/// NCBI TaxId: 2648276
/// </summary>
public abstract class unclassified_Parablennius : Parablennius, Iunclassified_Parablennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parablennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648276;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parablennius";
}
