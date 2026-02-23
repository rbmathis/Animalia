using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Halosauridae.Halosaurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Halosauridae.Halosaurus.unclassified_Halosaurus;

/// <summary>
/// Abstract class for unclassified Halosaurus (no rank).
/// NCBI TaxId: 3075084
/// </summary>
public abstract class unclassified_Halosaurus : Halosaurus, Iunclassified_Halosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Halosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3075084;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Halosaurus";
}
