using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae.Zenarchopterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae.Zenarchopterus.unclassified_Zenarchopterus;

/// <summary>
/// Abstract class for unclassified Zenarchopterus (no rank).
/// NCBI TaxId: 2621529
/// </summary>
public abstract class unclassified_Zenarchopterus : Zenarchopterus, Iunclassified_Zenarchopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zenarchopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621529;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zenarchopterus";
}
