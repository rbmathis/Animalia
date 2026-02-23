using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Aphanotorulus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Aphanotorulus.unclassified_Aphanotorulus;

/// <summary>
/// Abstract class for unclassified Aphanotorulus (no rank).
/// NCBI TaxId: 2642140
/// </summary>
public abstract class unclassified_Aphanotorulus : Aphanotorulus, Iunclassified_Aphanotorulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aphanotorulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642140;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aphanotorulus";
}
