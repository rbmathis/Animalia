using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Haplotaxodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Haplotaxodon.unclassified_Haplotaxodon;

/// <summary>
/// Abstract class for unclassified Haplotaxodon (no rank).
/// NCBI TaxId: 2637964
/// </summary>
public abstract class unclassified_Haplotaxodon : Haplotaxodon, Iunclassified_Haplotaxodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Haplotaxodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637964;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Haplotaxodon";
}
