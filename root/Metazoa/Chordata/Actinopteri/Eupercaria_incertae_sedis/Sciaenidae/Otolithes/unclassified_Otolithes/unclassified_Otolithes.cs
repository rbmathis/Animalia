using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Otolithes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Otolithes.unclassified_Otolithes;

/// <summary>
/// Abstract class for unclassified Otolithes (no rank).
/// NCBI TaxId: 2632517
/// </summary>
public abstract class unclassified_Otolithes : Otolithes, Iunclassified_Otolithes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Otolithes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632517;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Otolithes";
}
