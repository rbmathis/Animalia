using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Barygenys;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Barygenys.unclassified_Barygenys;

/// <summary>
/// Abstract class for unclassified Barygenys (no rank).
/// NCBI TaxId: 2862815
/// </summary>
public abstract class unclassified_Barygenys : Barygenys, Iunclassified_Barygenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Barygenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2862815;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Barygenys";
}
