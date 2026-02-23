using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Planiliza;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Planiliza.unclassified_Planiliza;

/// <summary>
/// Abstract class for unclassified Planiliza (no rank).
/// NCBI TaxId: 2678905
/// </summary>
public abstract class unclassified_Planiliza : Planiliza, Iunclassified_Planiliza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Planiliza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2678905;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Planiliza";
}
