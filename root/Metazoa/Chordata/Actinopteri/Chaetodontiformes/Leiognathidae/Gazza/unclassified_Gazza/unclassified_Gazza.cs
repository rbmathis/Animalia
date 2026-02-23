using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Gazza;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Gazza.unclassified_Gazza;

/// <summary>
/// Abstract class for unclassified Gazza (no rank).
/// NCBI TaxId: 2685210
/// </summary>
public abstract class unclassified_Gazza : Gazza, Iunclassified_Gazza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gazza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685210;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gazza";
}
