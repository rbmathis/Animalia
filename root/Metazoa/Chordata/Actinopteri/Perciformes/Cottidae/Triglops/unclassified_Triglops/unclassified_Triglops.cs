using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Triglops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Triglops.unclassified_Triglops;

/// <summary>
/// Abstract class for unclassified Triglops (no rank).
/// NCBI TaxId: 2636691
/// </summary>
public abstract class unclassified_Triglops : Triglops, Iunclassified_Triglops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Triglops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636691;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Triglops";
}
