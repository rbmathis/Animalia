using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Oxyporhamphus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Oxyporhamphus.unclassified_Oxyporhamphus;

/// <summary>
/// Abstract class for unclassified Oxyporhamphus (no rank).
/// NCBI TaxId: 2751847
/// </summary>
public abstract class unclassified_Oxyporhamphus : Oxyporhamphus, Iunclassified_Oxyporhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oxyporhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2751847;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oxyporhamphus";
}
