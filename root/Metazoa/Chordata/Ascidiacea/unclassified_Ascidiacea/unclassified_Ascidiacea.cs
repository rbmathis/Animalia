using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.unclassified_Ascidiacea;

/// <summary>
/// Abstract class for unclassified Ascidiacea (no rank).
/// NCBI TaxId: 948983
/// </summary>
public abstract class unclassified_Ascidiacea : Ascidiacea, Iunclassified_Ascidiacea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ascidiacea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 948983;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ascidiacea";
}
