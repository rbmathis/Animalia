using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Atrobucca;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Atrobucca.unclassified_Atrobucca;

/// <summary>
/// Abstract class for unclassified Atrobucca (no rank).
/// NCBI TaxId: 2626493
/// </summary>
public abstract class unclassified_Atrobucca : Atrobucca, Iunclassified_Atrobucca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atrobucca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626493;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atrobucca";
}
