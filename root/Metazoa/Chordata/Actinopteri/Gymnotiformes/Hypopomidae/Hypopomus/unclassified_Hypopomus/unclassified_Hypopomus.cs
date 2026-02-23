using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Hypopomidae.Hypopomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Hypopomidae.Hypopomus.unclassified_Hypopomus;

/// <summary>
/// Abstract class for unclassified Hypopomus (no rank).
/// NCBI TaxId: 2620124
/// </summary>
public abstract class unclassified_Hypopomus : Hypopomus, Iunclassified_Hypopomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypopomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620124;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypopomus";
}
