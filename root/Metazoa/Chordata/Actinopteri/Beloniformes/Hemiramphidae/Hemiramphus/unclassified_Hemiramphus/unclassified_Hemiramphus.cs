using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Hemiramphus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Hemiramphus.unclassified_Hemiramphus;

/// <summary>
/// Abstract class for unclassified Hemiramphus (no rank).
/// NCBI TaxId: 2633044
/// </summary>
public abstract class unclassified_Hemiramphus : Hemiramphus, Iunclassified_Hemiramphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemiramphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633044;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemiramphus";
}
