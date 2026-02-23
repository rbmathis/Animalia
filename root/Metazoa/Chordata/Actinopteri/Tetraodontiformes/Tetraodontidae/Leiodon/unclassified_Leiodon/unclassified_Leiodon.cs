using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Leiodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Leiodon.unclassified_Leiodon;

/// <summary>
/// Abstract class for unclassified Leiodon (no rank).
/// NCBI TaxId: 2644295
/// </summary>
public abstract class unclassified_Leiodon : Leiodon, Iunclassified_Leiodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leiodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644295;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leiodon";
}
