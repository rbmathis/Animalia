using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Boiga;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Boiga.unclassified_Boiga;

/// <summary>
/// Abstract class for unclassified Boiga (no rank).
/// NCBI TaxId: 2618334
/// </summary>
public abstract class unclassified_Boiga : Boiga, Iunclassified_Boiga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Boiga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618334;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Boiga";
}
