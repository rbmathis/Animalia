using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Cypselurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Cypselurus.unclassified_Cypselurus;

/// <summary>
/// Abstract class for unclassified Cypselurus (no rank).
/// NCBI TaxId: 2650288
/// </summary>
public abstract class unclassified_Cypselurus : Cypselurus, Iunclassified_Cypselurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cypselurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2650288;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cypselurus";
}
