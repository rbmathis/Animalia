using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Sclerophrys;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Sclerophrys.unclassified_Sclerophrys;

/// <summary>
/// Abstract class for unclassified Sclerophrys (no rank).
/// NCBI TaxId: 2643375
/// </summary>
public abstract class unclassified_Sclerophrys : Sclerophrys, Iunclassified_Sclerophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sclerophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643375;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sclerophrys";
}
