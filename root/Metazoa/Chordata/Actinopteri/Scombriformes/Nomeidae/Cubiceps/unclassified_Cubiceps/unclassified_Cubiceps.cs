using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Nomeidae.Cubiceps;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Nomeidae.Cubiceps.unclassified_Cubiceps;

/// <summary>
/// Abstract class for unclassified Cubiceps (no rank).
/// NCBI TaxId: 2648128
/// </summary>
public abstract class unclassified_Cubiceps : Cubiceps, Iunclassified_Cubiceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cubiceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648128;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cubiceps";
}
