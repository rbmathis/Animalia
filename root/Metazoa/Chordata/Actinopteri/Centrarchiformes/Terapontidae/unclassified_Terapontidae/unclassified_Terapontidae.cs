using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.unclassified_Terapontidae;

/// <summary>
/// Abstract class for unclassified Terapontidae (no rank).
/// NCBI TaxId: 2613829
/// </summary>
public abstract class unclassified_Terapontidae : Terapontidae, Iunclassified_Terapontidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Terapontidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2613829;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Terapontidae";
}
