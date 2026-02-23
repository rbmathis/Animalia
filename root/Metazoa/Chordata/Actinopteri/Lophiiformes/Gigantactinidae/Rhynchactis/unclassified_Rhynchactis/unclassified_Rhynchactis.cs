using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Gigantactinidae.Rhynchactis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Gigantactinidae.Rhynchactis.unclassified_Rhynchactis;

/// <summary>
/// Abstract class for unclassified Rhynchactis (no rank).
/// NCBI TaxId: 2638992
/// </summary>
public abstract class unclassified_Rhynchactis : Rhynchactis, Iunclassified_Rhynchactis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhynchactis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638992;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhynchactis";
}
