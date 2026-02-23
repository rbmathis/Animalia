using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Cuculus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Cuculus.unclassified_Cuculus;

/// <summary>
/// Abstract class for unclassified Cuculus (no rank).
/// NCBI TaxId: 3054302
/// </summary>
public abstract class unclassified_Cuculus : Cuculus, Iunclassified_Cuculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cuculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3054302;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cuculus";
}
