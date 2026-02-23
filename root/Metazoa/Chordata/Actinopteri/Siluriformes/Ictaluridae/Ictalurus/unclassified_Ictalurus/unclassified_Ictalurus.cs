using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae.Ictalurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae.Ictalurus.unclassified_Ictalurus;

/// <summary>
/// Abstract class for unclassified Ictalurus (no rank).
/// NCBI TaxId: 2638006
/// </summary>
public abstract class unclassified_Ictalurus : Ictalurus, Iunclassified_Ictalurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ictalurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638006;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ictalurus";
}
