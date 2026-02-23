using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Gnathocharax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Gnathocharax.unclassified_Gnathocharax;

/// <summary>
/// Abstract class for unclassified Gnathocharax (no rank).
/// NCBI TaxId: 2627477
/// </summary>
public abstract class unclassified_Gnathocharax : Gnathocharax, Iunclassified_Gnathocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gnathocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627477;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gnathocharax";
}
