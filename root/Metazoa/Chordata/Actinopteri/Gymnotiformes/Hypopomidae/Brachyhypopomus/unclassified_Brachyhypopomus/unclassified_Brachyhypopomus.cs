using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Hypopomidae.Brachyhypopomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Hypopomidae.Brachyhypopomus.unclassified_Brachyhypopomus;

/// <summary>
/// Abstract class for unclassified Brachyhypopomus (no rank).
/// NCBI TaxId: 2625174
/// </summary>
public abstract class unclassified_Brachyhypopomus : Brachyhypopomus, Iunclassified_Brachyhypopomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brachyhypopomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625174;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brachyhypopomus";
}
