using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Dischistodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Dischistodus.unclassified_Dischistodus;

/// <summary>
/// Abstract class for unclassified Dischistodus (no rank).
/// NCBI TaxId: 3419101
/// </summary>
public abstract class unclassified_Dischistodus : Dischistodus, Iunclassified_Dischistodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dischistodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3419101;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dischistodus";
}
