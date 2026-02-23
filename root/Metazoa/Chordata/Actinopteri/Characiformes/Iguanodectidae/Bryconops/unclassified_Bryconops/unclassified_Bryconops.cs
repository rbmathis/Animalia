using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Iguanodectidae.Bryconops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Iguanodectidae.Bryconops.unclassified_Bryconops;

/// <summary>
/// Abstract class for unclassified Bryconops (no rank).
/// NCBI TaxId: 2608177
/// </summary>
public abstract class unclassified_Bryconops : Bryconops, Iunclassified_Bryconops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bryconops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608177;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bryconops";
}
