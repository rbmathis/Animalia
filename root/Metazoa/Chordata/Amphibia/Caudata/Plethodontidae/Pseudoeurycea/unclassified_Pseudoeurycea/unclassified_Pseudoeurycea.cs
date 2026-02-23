using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Pseudoeurycea;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Pseudoeurycea.unclassified_Pseudoeurycea;

/// <summary>
/// Abstract class for unclassified Pseudoeurycea (no rank).
/// NCBI TaxId: 2636779
/// </summary>
public abstract class unclassified_Pseudoeurycea : Pseudoeurycea, Iunclassified_Pseudoeurycea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudoeurycea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636779;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudoeurycea";
}
