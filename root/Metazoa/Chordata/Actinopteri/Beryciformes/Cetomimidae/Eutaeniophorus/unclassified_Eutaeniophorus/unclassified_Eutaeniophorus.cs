using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Eutaeniophorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Eutaeniophorus.unclassified_Eutaeniophorus;

/// <summary>
/// Abstract class for unclassified Eutaeniophorus (no rank).
/// NCBI TaxId: 2646441
/// </summary>
public abstract class unclassified_Eutaeniophorus : Eutaeniophorus, Iunclassified_Eutaeniophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eutaeniophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646441;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eutaeniophorus";
}
