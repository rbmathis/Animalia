using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Charax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Charax.unclassified_Charax;

/// <summary>
/// Abstract class for unclassified Charax (no rank).
/// NCBI TaxId: 2622075
/// </summary>
public abstract class unclassified_Charax : Charax, Iunclassified_Charax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Charax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622075;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Charax";
}
