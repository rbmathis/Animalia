using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Sinibrama;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Sinibrama.unclassified_Sinibrama;

/// <summary>
/// Abstract class for unclassified Sinibrama (no rank).
/// NCBI TaxId: 2618629
/// </summary>
public abstract class unclassified_Sinibrama : Sinibrama, Iunclassified_Sinibrama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sinibrama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618629;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sinibrama";
}
