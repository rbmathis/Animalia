using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Triplophysa;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Triplophysa.unclassified_Triplophysa;

/// <summary>
/// Abstract class for unclassified Triplophysa (no rank).
/// NCBI TaxId: 2649812
/// </summary>
public abstract class unclassified_Triplophysa : Triplophysa, Iunclassified_Triplophysa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Triplophysa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649812;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Triplophysa";
}
