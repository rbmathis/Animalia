using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Soriculus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Soriculus.unclassified_Soriculus;

/// <summary>
/// Abstract class for unclassified Soriculus (no rank).
/// NCBI TaxId: 3055554
/// </summary>
public abstract class unclassified_Soriculus : Soriculus, Iunclassified_Soriculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Soriculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3055554;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Soriculus";
}
