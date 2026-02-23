using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Distocyclus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Distocyclus.unclassified_Distocyclus;

/// <summary>
/// Abstract class for unclassified Distocyclus (no rank).
/// NCBI TaxId: 2640637
/// </summary>
public abstract class unclassified_Distocyclus : Distocyclus, Iunclassified_Distocyclus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Distocyclus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640637;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Distocyclus";
}
