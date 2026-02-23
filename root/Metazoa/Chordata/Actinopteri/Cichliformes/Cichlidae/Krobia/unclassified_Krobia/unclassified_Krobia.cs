using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Krobia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Krobia.unclassified_Krobia;

/// <summary>
/// Abstract class for unclassified Krobia (no rank).
/// NCBI TaxId: 2633639
/// </summary>
public abstract class unclassified_Krobia : Krobia, Iunclassified_Krobia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Krobia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633639;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Krobia";
}
