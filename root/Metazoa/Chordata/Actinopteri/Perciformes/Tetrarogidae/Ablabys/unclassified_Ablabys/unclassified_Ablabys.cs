using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Ablabys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Ablabys.unclassified_Ablabys;

/// <summary>
/// Abstract class for unclassified Ablabys (no rank).
/// NCBI TaxId: 2640589
/// </summary>
public abstract class unclassified_Ablabys : Ablabys, Iunclassified_Ablabys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ablabys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640589;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ablabys";
}
