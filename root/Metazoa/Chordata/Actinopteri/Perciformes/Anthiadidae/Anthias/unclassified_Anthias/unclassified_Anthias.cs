using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Anthias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Anthias.unclassified_Anthias;

/// <summary>
/// Abstract class for unclassified Anthias (no rank).
/// NCBI TaxId: 2916430
/// </summary>
public abstract class unclassified_Anthias : Anthias, Iunclassified_Anthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2916430;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anthias";
}
