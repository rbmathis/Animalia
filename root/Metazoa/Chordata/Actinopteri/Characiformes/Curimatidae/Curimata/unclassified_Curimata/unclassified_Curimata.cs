using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Curimata;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Curimata.unclassified_Curimata;

/// <summary>
/// Abstract class for unclassified Curimata (no rank).
/// NCBI TaxId: 2630736
/// </summary>
public abstract class unclassified_Curimata : Curimata, Iunclassified_Curimata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Curimata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630736;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Curimata";
}
