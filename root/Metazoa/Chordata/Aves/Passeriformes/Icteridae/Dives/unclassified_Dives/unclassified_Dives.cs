using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Dives;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Dives.unclassified_Dives;

/// <summary>
/// Abstract class for unclassified Dives (no rank).
/// NCBI TaxId: 3241026
/// </summary>
public abstract class unclassified_Dives : Dives, Iunclassified_Dives
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dives";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3241026;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dives";
}
