using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Cheirodontops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Cheirodontops.unclassified_Cheirodontops;

/// <summary>
/// Abstract class for unclassified Cheirodontops (no rank).
/// NCBI TaxId: 2642141
/// </summary>
public abstract class unclassified_Cheirodontops : Cheirodontops, Iunclassified_Cheirodontops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cheirodontops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642141;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cheirodontops";
}
