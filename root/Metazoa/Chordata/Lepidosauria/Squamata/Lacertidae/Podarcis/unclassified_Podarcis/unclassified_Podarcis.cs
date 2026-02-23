using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Podarcis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Podarcis.unclassified_Podarcis;

/// <summary>
/// Abstract class for unclassified Podarcis (no rank).
/// NCBI TaxId: 2632023
/// </summary>
public abstract class unclassified_Podarcis : Podarcis, Iunclassified_Podarcis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Podarcis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632023;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Podarcis";
}
