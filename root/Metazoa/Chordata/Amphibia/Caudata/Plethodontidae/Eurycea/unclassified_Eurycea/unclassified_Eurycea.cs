using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Eurycea;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Eurycea.unclassified_Eurycea;

/// <summary>
/// Abstract class for unclassified Eurycea (no rank).
/// NCBI TaxId: 2647200
/// </summary>
public abstract class unclassified_Eurycea : Eurycea, Iunclassified_Eurycea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eurycea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647200;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eurycea";
}
