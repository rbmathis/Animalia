using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Paratrypauchen;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Paratrypauchen.unclassified_Paratrypauchen;

/// <summary>
/// Abstract class for unclassified Paratrypauchen (no rank).
/// NCBI TaxId: 2624066
/// </summary>
public abstract class unclassified_Paratrypauchen : Paratrypauchen, Iunclassified_Paratrypauchen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paratrypauchen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624066;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paratrypauchen";
}
