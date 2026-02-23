using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.unclassified_Viperidae;

/// <summary>
/// Abstract class for unclassified Viperidae (no rank).
/// NCBI TaxId: 3061911
/// </summary>
public abstract class unclassified_Viperidae : Viperidae, Iunclassified_Viperidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Viperidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3061911;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Viperidae";
}
