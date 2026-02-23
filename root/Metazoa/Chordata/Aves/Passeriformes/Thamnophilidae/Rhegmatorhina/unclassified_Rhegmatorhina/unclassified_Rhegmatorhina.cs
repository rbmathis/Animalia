using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Rhegmatorhina;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Rhegmatorhina.unclassified_Rhegmatorhina;

/// <summary>
/// Abstract class for unclassified Rhegmatorhina (no rank).
/// NCBI TaxId: 2634445
/// </summary>
public abstract class unclassified_Rhegmatorhina : Rhegmatorhina, Iunclassified_Rhegmatorhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhegmatorhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634445;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhegmatorhina";
}
