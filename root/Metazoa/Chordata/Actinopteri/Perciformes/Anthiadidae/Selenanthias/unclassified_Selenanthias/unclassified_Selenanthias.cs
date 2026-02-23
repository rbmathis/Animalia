using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Selenanthias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Selenanthias.unclassified_Selenanthias;

/// <summary>
/// Abstract class for unclassified Selenanthias (no rank).
/// NCBI TaxId: 3414475
/// </summary>
public abstract class unclassified_Selenanthias : Selenanthias, Iunclassified_Selenanthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Selenanthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3414475;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Selenanthias";
}
