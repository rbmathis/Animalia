using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Nantis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Nantis.unclassified_Nantis;

/// <summary>
/// Abstract class for unclassified Nantis (no rank).
/// NCBI TaxId: 2677551
/// </summary>
public abstract class unclassified_Nantis : Nantis, Iunclassified_Nantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677551;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nantis";
}
