using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Aquiloeurycea;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Aquiloeurycea.unclassified_Aquiloeurycea;

/// <summary>
/// Abstract class for unclassified Aquiloeurycea (no rank).
/// NCBI TaxId: 2739920
/// </summary>
public abstract class unclassified_Aquiloeurycea : Aquiloeurycea, Iunclassified_Aquiloeurycea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aquiloeurycea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2739920;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aquiloeurycea";
}
