using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Amblyotrypauchen;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Amblyotrypauchen.unclassified_Amblyotrypauchen;

/// <summary>
/// Abstract class for unclassified Amblyotrypauchen (no rank).
/// NCBI TaxId: 3127354
/// </summary>
public abstract class unclassified_Amblyotrypauchen : Amblyotrypauchen, Iunclassified_Amblyotrypauchen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amblyotrypauchen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3127354;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amblyotrypauchen";
}
