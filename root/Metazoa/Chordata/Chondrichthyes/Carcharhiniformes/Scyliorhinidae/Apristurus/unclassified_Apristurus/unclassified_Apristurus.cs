using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Apristurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Apristurus.unclassified_Apristurus;

/// <summary>
/// Abstract class for unclassified Apristurus (no rank).
/// NCBI TaxId: 2624621
/// </summary>
public abstract class unclassified_Apristurus : Apristurus, Iunclassified_Apristurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Apristurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624621;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Apristurus";
}
