using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Nycteridae.Nycteris;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Nycteridae.Nycteris.unclassified_Nycteris;

/// <summary>
/// Abstract class for unclassified Nycteris (no rank).
/// NCBI TaxId: 2623095
/// </summary>
public abstract class unclassified_Nycteris : Nycteris, Iunclassified_Nycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623095;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nycteris";
}
