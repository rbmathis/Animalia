using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Carpiodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Carpiodes.unclassified_Carpiodes;

/// <summary>
/// Abstract class for unclassified Carpiodes (no rank).
/// NCBI TaxId: 3447069
/// </summary>
public abstract class unclassified_Carpiodes : Carpiodes, Iunclassified_Carpiodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Carpiodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3447069;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Carpiodes";
}
