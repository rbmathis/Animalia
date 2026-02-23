using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Epibulus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Epibulus.unclassified_Epibulus;

/// <summary>
/// Abstract class for unclassified Epibulus (no rank).
/// NCBI TaxId: 2990288
/// </summary>
public abstract class unclassified_Epibulus : Epibulus, Iunclassified_Epibulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Epibulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2990288;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Epibulus";
}
