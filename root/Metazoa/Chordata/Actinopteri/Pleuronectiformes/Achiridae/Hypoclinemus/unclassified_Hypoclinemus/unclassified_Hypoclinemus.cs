using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae.Hypoclinemus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae.Hypoclinemus.unclassified_Hypoclinemus;

/// <summary>
/// Abstract class for unclassified Hypoclinemus (no rank).
/// NCBI TaxId: 2629764
/// </summary>
public abstract class unclassified_Hypoclinemus : Hypoclinemus, Iunclassified_Hypoclinemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypoclinemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629764;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypoclinemus";
}
