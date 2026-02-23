using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Proterorhinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Proterorhinus.unclassified_Proterorhinus;

/// <summary>
/// Abstract class for unclassified Proterorhinus (no rank).
/// NCBI TaxId: 2622202
/// </summary>
public abstract class unclassified_Proterorhinus : Proterorhinus, Iunclassified_Proterorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Proterorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622202;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Proterorhinus";
}
