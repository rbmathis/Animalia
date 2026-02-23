using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Sabanejewia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Sabanejewia.unclassified_Sabanejewia;

/// <summary>
/// Abstract class for unclassified Sabanejewia (no rank).
/// NCBI TaxId: 2633098
/// </summary>
public abstract class unclassified_Sabanejewia : Sabanejewia, Iunclassified_Sabanejewia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sabanejewia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633098;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sabanejewia";
}
