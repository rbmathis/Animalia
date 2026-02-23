using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Rhabdoblennius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Rhabdoblennius.unclassified_Rhabdoblennius;

/// <summary>
/// Abstract class for unclassified Rhabdoblennius (no rank).
/// NCBI TaxId: 2639820
/// </summary>
public abstract class unclassified_Rhabdoblennius : Rhabdoblennius, Iunclassified_Rhabdoblennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhabdoblennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639820;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhabdoblennius";
}
