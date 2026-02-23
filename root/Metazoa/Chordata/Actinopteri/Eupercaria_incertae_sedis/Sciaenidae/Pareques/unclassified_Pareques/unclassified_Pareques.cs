using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pareques;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pareques.unclassified_Pareques;

/// <summary>
/// Abstract class for unclassified Pareques (no rank).
/// NCBI TaxId: 2641636
/// </summary>
public abstract class unclassified_Pareques : Pareques, Iunclassified_Pareques
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pareques";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641636;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pareques";
}
