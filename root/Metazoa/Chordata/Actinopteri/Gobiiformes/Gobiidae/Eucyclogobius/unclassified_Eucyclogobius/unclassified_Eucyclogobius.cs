using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Eucyclogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Eucyclogobius.unclassified_Eucyclogobius;

/// <summary>
/// Abstract class for unclassified Eucyclogobius (no rank).
/// NCBI TaxId: 2648025
/// </summary>
public abstract class unclassified_Eucyclogobius : Eucyclogobius, Iunclassified_Eucyclogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eucyclogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648025;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eucyclogobius";
}
