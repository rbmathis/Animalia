using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Trigonostigma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Trigonostigma.unclassified_Trigonostigma;

/// <summary>
/// Abstract class for unclassified Trigonostigma (no rank).
/// NCBI TaxId: 2781027
/// </summary>
public abstract class unclassified_Trigonostigma : Trigonostigma, Iunclassified_Trigonostigma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trigonostigma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2781027;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trigonostigma";
}
