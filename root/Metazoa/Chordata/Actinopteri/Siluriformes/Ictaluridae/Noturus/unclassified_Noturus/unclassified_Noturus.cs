using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae.Noturus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae.Noturus.unclassified_Noturus;

/// <summary>
/// Abstract class for unclassified Noturus (no rank).
/// NCBI TaxId: 2641411
/// </summary>
public abstract class unclassified_Noturus : Noturus, Iunclassified_Noturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Noturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641411;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Noturus";
}
