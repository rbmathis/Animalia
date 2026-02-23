using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobiopterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobiopterus.unclassified_Gobiopterus;

/// <summary>
/// Abstract class for unclassified Gobiopterus (no rank).
/// NCBI TaxId: 2643524
/// </summary>
public abstract class unclassified_Gobiopterus : Gobiopterus, Iunclassified_Gobiopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gobiopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643524;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gobiopterus";
}
