using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Microcobitis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Microcobitis.unclassified_Microcobitis;

/// <summary>
/// Abstract class for unclassified Microcobitis (no rank).
/// NCBI TaxId: 2629410
/// </summary>
public abstract class unclassified_Microcobitis : Microcobitis, Iunclassified_Microcobitis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microcobitis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629410;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microcobitis";
}
