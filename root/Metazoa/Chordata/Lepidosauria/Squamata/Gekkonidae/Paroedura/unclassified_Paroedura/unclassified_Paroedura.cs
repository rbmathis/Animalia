using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Paroedura;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Paroedura.unclassified_Paroedura;

/// <summary>
/// Abstract class for unclassified Paroedura (no rank).
/// NCBI TaxId: 2640277
/// </summary>
public abstract class unclassified_Paroedura : Paroedura, Iunclassified_Paroedura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paroedura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640277;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paroedura";
}
