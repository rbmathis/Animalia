using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Laetacara;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Laetacara.unclassified_Laetacara;

/// <summary>
/// Abstract class for unclassified Laetacara (no rank).
/// NCBI TaxId: 2621016
/// </summary>
public abstract class unclassified_Laetacara : Laetacara, Iunclassified_Laetacara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Laetacara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621016;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Laetacara";
}
