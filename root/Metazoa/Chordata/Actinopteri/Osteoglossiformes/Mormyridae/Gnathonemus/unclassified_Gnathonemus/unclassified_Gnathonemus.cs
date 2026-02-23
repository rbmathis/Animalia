using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Gnathonemus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Gnathonemus.unclassified_Gnathonemus;

/// <summary>
/// Abstract class for unclassified Gnathonemus (no rank).
/// NCBI TaxId: 2634092
/// </summary>
public abstract class unclassified_Gnathonemus : Gnathonemus, Iunclassified_Gnathonemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gnathonemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634092;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gnathonemus";
}
