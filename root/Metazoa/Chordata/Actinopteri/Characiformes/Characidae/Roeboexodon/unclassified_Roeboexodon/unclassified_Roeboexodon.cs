using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Roeboexodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Roeboexodon.unclassified_Roeboexodon;

/// <summary>
/// Abstract class for unclassified Roeboexodon (no rank).
/// NCBI TaxId: 3101905
/// </summary>
public abstract class unclassified_Roeboexodon : Roeboexodon, Iunclassified_Roeboexodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Roeboexodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101905;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Roeboexodon";
}
