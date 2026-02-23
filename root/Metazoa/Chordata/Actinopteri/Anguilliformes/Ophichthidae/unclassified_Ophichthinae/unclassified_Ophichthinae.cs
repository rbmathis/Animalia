using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.unclassified_Ophichthinae;

/// <summary>
/// Abstract class for unclassified Ophichthinae (no rank).
/// NCBI TaxId: 1189021
/// </summary>
public abstract class unclassified_Ophichthinae : Ophichthidae, Iunclassified_Ophichthinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ophichthinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1189021;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ophichthinae";
}
