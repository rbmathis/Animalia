using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Zaireichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Zaireichthys.unclassified_Zaireichthys;

/// <summary>
/// Abstract class for unclassified Zaireichthys (no rank).
/// NCBI TaxId: 2642546
/// </summary>
public abstract class unclassified_Zaireichthys : Zaireichthys, Iunclassified_Zaireichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zaireichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642546;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zaireichthys";
}
