using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Trypauchen;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Trypauchen.unclassified_Trypauchen;

/// <summary>
/// Abstract class for unclassified Trypauchen (no rank).
/// NCBI TaxId: 2637833
/// </summary>
public abstract class unclassified_Trypauchen : Trypauchen, Iunclassified_Trypauchen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trypauchen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637833;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trypauchen";
}
