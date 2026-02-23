using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Mystacoleucus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Mystacoleucus.unclassified_Mystacoleucus;

/// <summary>
/// Abstract class for unclassified Mystacoleucus (no rank).
/// NCBI TaxId: 2629399
/// </summary>
public abstract class unclassified_Mystacoleucus : Mystacoleucus, Iunclassified_Mystacoleucus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mystacoleucus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629399;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mystacoleucus";
}
