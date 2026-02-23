using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Serinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Serinus.unclassified_Serinus;

/// <summary>
/// Abstract class for unclassified Serinus (no rank).
/// NCBI TaxId: 2642664
/// </summary>
public abstract class unclassified_Serinus : Serinus, Iunclassified_Serinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Serinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642664;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Serinus";
}
