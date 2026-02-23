using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Thalasseleotrididae.Thalasseleotris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Thalasseleotrididae.Thalasseleotris.unclassified_Thalasseleotris;

/// <summary>
/// Abstract class for unclassified Thalasseleotris (no rank).
/// NCBI TaxId: 2625917
/// </summary>
public abstract class unclassified_Thalasseleotris : Thalasseleotris, Iunclassified_Thalasseleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thalasseleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625917;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thalasseleotris";
}
