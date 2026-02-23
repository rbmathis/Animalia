using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Pseudanthias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Pseudanthias.unclassified_Pseudanthias;

/// <summary>
/// Abstract class for unclassified Pseudanthias (no rank).
/// NCBI TaxId: 2620976
/// </summary>
public abstract class unclassified_Pseudanthias : Pseudanthias, Iunclassified_Pseudanthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudanthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620976;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudanthias";
}
