using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Pseudorasbora;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Pseudorasbora.unclassified_Pseudorasbora;

/// <summary>
/// Abstract class for unclassified Pseudorasbora (no rank).
/// NCBI TaxId: 2647838
/// </summary>
public abstract class unclassified_Pseudorasbora : Pseudorasbora, Iunclassified_Pseudorasbora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudorasbora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647838;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudorasbora";
}
