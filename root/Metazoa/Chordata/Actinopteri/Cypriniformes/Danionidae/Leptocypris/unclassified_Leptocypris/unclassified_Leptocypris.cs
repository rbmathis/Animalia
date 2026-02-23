using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Leptocypris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Leptocypris.unclassified_Leptocypris;

/// <summary>
/// Abstract class for unclassified Leptocypris (no rank).
/// NCBI TaxId: 2619693
/// </summary>
public abstract class unclassified_Leptocypris : Leptocypris, Iunclassified_Leptocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619693;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptocypris";
}
