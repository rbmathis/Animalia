using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Thalassoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Thalassoma.unclassified_Thalassoma;

/// <summary>
/// Abstract class for unclassified Thalassoma (no rank).
/// NCBI TaxId: 2623977
/// </summary>
public abstract class unclassified_Thalassoma : Thalassoma, Iunclassified_Thalassoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thalassoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623977;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thalassoma";
}
