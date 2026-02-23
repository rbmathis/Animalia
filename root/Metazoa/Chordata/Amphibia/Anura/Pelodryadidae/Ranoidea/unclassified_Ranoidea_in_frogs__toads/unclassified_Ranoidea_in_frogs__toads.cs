using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Ranoidea;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Ranoidea.unclassified_Ranoidea_in_frogs__toads;

/// <summary>
/// Abstract class for unclassified Ranoidea (in: frogs & toads) (no rank).
/// NCBI TaxId: 3407091
/// </summary>
public abstract class unclassified_Ranoidea_in_frogs__toads : Ranoidea, Iunclassified_Ranoidea_in_frogs__toads
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ranoidea (in: frogs & toads)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3407091;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ranoidea_in_frogs__toads";
}
