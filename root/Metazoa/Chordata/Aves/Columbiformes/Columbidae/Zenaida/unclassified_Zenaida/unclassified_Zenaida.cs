using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Zenaida;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Zenaida.unclassified_Zenaida;

/// <summary>
/// Abstract class for unclassified Zenaida (no rank).
/// NCBI TaxId: 2805845
/// </summary>
public abstract class unclassified_Zenaida : Zenaida, Iunclassified_Zenaida
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zenaida";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2805845;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zenaida";
}
