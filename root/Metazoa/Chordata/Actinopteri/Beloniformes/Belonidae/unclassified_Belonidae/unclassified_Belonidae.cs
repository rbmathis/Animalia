using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.unclassified_Belonidae;

/// <summary>
/// Abstract class for unclassified Belonidae (no rank).
/// NCBI TaxId: 1182054
/// </summary>
public abstract class unclassified_Belonidae : Belonidae, Iunclassified_Belonidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Belonidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182054;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Belonidae";
}
