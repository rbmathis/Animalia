using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Centrophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Centrophoridae.unclassified_Centrophoridae;

/// <summary>
/// Abstract class for unclassified Centrophoridae (no rank).
/// NCBI TaxId: 1471647
/// </summary>
public abstract class unclassified_Centrophoridae : Centrophoridae, Iunclassified_Centrophoridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Centrophoridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1471647;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Centrophoridae";
}
