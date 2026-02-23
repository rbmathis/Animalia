using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Seleniolycus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Seleniolycus.unclassified_Seleniolycus;

/// <summary>
/// Abstract class for unclassified Seleniolycus (no rank).
/// NCBI TaxId: 3448523
/// </summary>
public abstract class unclassified_Seleniolycus : Seleniolycus, Iunclassified_Seleniolycus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Seleniolycus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3448523;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Seleniolycus";
}
