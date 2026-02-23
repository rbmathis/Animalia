using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Aulonocara;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Aulonocara.unclassified_Aulonocara;

/// <summary>
/// Abstract class for unclassified Aulonocara (no rank).
/// NCBI TaxId: 2639218
/// </summary>
public abstract class unclassified_Aulonocara : Aulonocara, Iunclassified_Aulonocara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aulonocara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639218;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aulonocara";
}
