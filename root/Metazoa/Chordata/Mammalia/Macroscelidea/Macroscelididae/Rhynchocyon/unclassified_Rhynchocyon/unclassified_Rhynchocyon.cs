using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae.Rhynchocyon;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae.Rhynchocyon.unclassified_Rhynchocyon;

/// <summary>
/// Abstract class for unclassified Rhynchocyon (no rank).
/// NCBI TaxId: 2623089
/// </summary>
public abstract class unclassified_Rhynchocyon : Rhynchocyon, Iunclassified_Rhynchocyon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhynchocyon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623089;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhynchocyon";
}
