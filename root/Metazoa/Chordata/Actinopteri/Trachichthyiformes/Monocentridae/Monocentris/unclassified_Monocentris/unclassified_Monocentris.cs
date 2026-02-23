using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Monocentridae.Monocentris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Monocentridae.Monocentris.unclassified_Monocentris;

/// <summary>
/// Abstract class for unclassified Monocentris (no rank).
/// NCBI TaxId: 2927214
/// </summary>
public abstract class unclassified_Monocentris : Monocentris, Iunclassified_Monocentris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Monocentris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2927214;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Monocentris";
}
