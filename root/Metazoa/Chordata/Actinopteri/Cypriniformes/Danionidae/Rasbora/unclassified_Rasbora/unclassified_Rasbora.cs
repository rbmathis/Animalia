using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Rasbora;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Rasbora.unclassified_Rasbora;

/// <summary>
/// Abstract class for unclassified Rasbora (no rank).
/// NCBI TaxId: 2629537
/// </summary>
public abstract class unclassified_Rasbora : Rasbora, Iunclassified_Rasbora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rasbora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629537;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rasbora";
}
