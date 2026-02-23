using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Tadarida;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Tadarida.unclassified_Tadarida;

/// <summary>
/// Abstract class for unclassified Tadarida (no rank).
/// NCBI TaxId: 2636308
/// </summary>
public abstract class unclassified_Tadarida : Tadarida, Iunclassified_Tadarida
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tadarida";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636308;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tadarida";
}
