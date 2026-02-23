using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Guianacara;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Guianacara.unclassified_Guianacara;

/// <summary>
/// Abstract class for unclassified Guianacara (no rank).
/// NCBI TaxId: 2622772
/// </summary>
public abstract class unclassified_Guianacara : Guianacara, Iunclassified_Guianacara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Guianacara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622772;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Guianacara";
}
