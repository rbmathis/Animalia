using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae.Osteoglossum;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae.Osteoglossum.unclassified_Osteoglossum;

/// <summary>
/// Abstract class for unclassified Osteoglossum (no rank).
/// NCBI TaxId: 2625562
/// </summary>
public abstract class unclassified_Osteoglossum : Osteoglossum, Iunclassified_Osteoglossum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Osteoglossum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625562;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Osteoglossum";
}
