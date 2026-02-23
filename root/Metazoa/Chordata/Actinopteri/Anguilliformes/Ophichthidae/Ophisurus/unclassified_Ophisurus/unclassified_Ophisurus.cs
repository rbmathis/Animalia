using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Ophisurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Ophisurus.unclassified_Ophisurus;

/// <summary>
/// Abstract class for unclassified Ophisurus (no rank).
/// NCBI TaxId: 2997192
/// </summary>
public abstract class unclassified_Ophisurus : Ophisurus, Iunclassified_Ophisurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ophisurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2997192;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ophisurus";
}
