using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Cymolutes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Cymolutes.unclassified_Cymolutes;

/// <summary>
/// Abstract class for unclassified Cymolutes (no rank).
/// NCBI TaxId: 2990173
/// </summary>
public abstract class unclassified_Cymolutes : Cymolutes, Iunclassified_Cymolutes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cymolutes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2990173;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cymolutes";
}
