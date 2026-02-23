using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Halichoeres;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Halichoeres.unclassified_Halichoeres;

/// <summary>
/// Abstract class for unclassified Halichoeres (no rank).
/// NCBI TaxId: 2684984
/// </summary>
public abstract class unclassified_Halichoeres : Halichoeres, Iunclassified_Halichoeres
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Halichoeres";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2684984;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Halichoeres";
}
