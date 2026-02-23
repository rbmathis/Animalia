using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Notopteridae.Papyrocranus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Notopteridae.Papyrocranus.unclassified_Papyrocranus;

/// <summary>
/// Abstract class for unclassified Papyrocranus (no rank).
/// NCBI TaxId: 2625059
/// </summary>
public abstract class unclassified_Papyrocranus : Papyrocranus, Iunclassified_Papyrocranus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Papyrocranus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625059;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Papyrocranus";
}
