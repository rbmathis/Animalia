using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pempheridae.Pempheris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pempheridae.Pempheris.unclassified_Pempheris;

/// <summary>
/// Abstract class for unclassified Pempheris (no rank).
/// NCBI TaxId: 2609518
/// </summary>
public abstract class unclassified_Pempheris : Pempheris, Iunclassified_Pempheris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pempheris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609518;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pempheris";
}
