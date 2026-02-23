using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Trichogaster;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Trichogaster.unclassified_Trichogaster;

/// <summary>
/// Abstract class for unclassified Trichogaster (no rank).
/// NCBI TaxId: 2636906
/// </summary>
public abstract class unclassified_Trichogaster : Trichogaster, Iunclassified_Trichogaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trichogaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636906;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trichogaster";
}
