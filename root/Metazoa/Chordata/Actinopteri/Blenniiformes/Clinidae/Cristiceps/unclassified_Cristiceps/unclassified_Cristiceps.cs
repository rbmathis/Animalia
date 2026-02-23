using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Cristiceps;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Cristiceps.unclassified_Cristiceps;

/// <summary>
/// Abstract class for unclassified Cristiceps (no rank).
/// NCBI TaxId: 2642045
/// </summary>
public abstract class unclassified_Cristiceps : Cristiceps, Iunclassified_Cristiceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cristiceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642045;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cristiceps";
}
