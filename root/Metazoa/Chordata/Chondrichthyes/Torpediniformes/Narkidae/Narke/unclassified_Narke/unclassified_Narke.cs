using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narkidae.Narke;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narkidae.Narke.unclassified_Narke;

/// <summary>
/// Abstract class for unclassified Narke (no rank).
/// NCBI TaxId: 2755193
/// </summary>
public abstract class unclassified_Narke : Narke, Iunclassified_Narke
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Narke";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2755193;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Narke";
}
