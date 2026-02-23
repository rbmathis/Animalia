using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Geogale;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Geogale.unclassified_Geogale;

/// <summary>
/// Abstract class for unclassified Geogale (no rank).
/// NCBI TaxId: 2621127
/// </summary>
public abstract class unclassified_Geogale : Geogale, Iunclassified_Geogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Geogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621127;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Geogale";
}
