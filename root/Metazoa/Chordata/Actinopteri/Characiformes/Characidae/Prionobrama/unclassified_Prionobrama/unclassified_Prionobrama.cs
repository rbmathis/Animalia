using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Prionobrama;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Prionobrama.unclassified_Prionobrama;

/// <summary>
/// Abstract class for unclassified Prionobrama (no rank).
/// NCBI TaxId: 2618766
/// </summary>
public abstract class unclassified_Prionobrama : Prionobrama, Iunclassified_Prionobrama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Prionobrama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618766;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Prionobrama";
}
