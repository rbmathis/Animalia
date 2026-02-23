using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae.Ameiurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae.Ameiurus.unclassified_Ameiurus;

/// <summary>
/// Abstract class for unclassified Ameiurus (no rank).
/// NCBI TaxId: 2634433
/// </summary>
public abstract class unclassified_Ameiurus : Ameiurus, Iunclassified_Ameiurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ameiurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634433;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ameiurus";
}
