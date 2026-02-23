using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudancistrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudancistrus.unclassified_Pseudancistrus;

/// <summary>
/// Abstract class for unclassified Pseudancistrus (no rank).
/// NCBI TaxId: 2635329
/// </summary>
public abstract class unclassified_Pseudancistrus : Pseudancistrus, Iunclassified_Pseudancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635329;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudancistrus";
}
