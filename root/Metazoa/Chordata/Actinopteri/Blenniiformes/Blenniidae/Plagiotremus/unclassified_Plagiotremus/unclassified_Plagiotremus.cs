using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Plagiotremus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Plagiotremus.unclassified_Plagiotremus;

/// <summary>
/// Abstract class for unclassified Plagiotremus (no rank).
/// NCBI TaxId: 2631584
/// </summary>
public abstract class unclassified_Plagiotremus : Plagiotremus, Iunclassified_Plagiotremus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plagiotremus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631584;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plagiotremus";
}
