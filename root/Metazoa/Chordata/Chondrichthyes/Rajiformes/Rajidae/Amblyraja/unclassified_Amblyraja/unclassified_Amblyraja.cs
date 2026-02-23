using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Amblyraja;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Amblyraja.unclassified_Amblyraja;

/// <summary>
/// Abstract class for unclassified Amblyraja (no rank).
/// NCBI TaxId: 2644890
/// </summary>
public abstract class unclassified_Amblyraja : Amblyraja, Iunclassified_Amblyraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amblyraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644890;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amblyraja";
}
