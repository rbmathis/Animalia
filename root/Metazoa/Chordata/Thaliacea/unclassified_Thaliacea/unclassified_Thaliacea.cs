using AnimalKingdom.root.Metazoa.Chordata.Thaliacea;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.unclassified_Thaliacea;

/// <summary>
/// Abstract class for unclassified Thaliacea (no rank).
/// NCBI TaxId: 2565469
/// </summary>
public abstract class unclassified_Thaliacea : Thaliacea, Iunclassified_Thaliacea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thaliacea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2565469;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thaliacea";
}
