using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.Holocentrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.Holocentrus.unclassified_Holocentrus;

/// <summary>
/// Abstract class for unclassified Holocentrus (no rank).
/// NCBI TaxId: 2643877
/// </summary>
public abstract class unclassified_Holocentrus : Holocentrus, Iunclassified_Holocentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Holocentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643877;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Holocentrus";
}
