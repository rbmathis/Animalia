using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Hyporhamphus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Hyporhamphus.unclassified_Hyporhamphus;

/// <summary>
/// Abstract class for unclassified Hyporhamphus (no rank).
/// NCBI TaxId: 2620643
/// </summary>
public abstract class unclassified_Hyporhamphus : Hyporhamphus, Iunclassified_Hyporhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hyporhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620643;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hyporhamphus";
}
