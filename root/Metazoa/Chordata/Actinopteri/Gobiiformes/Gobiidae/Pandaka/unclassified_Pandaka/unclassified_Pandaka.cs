using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pandaka;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pandaka.unclassified_Pandaka;

/// <summary>
/// Abstract class for unclassified Pandaka (no rank).
/// NCBI TaxId: 2824009
/// </summary>
public abstract class unclassified_Pandaka : Pandaka, Iunclassified_Pandaka
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pandaka";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2824009;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pandaka";
}
