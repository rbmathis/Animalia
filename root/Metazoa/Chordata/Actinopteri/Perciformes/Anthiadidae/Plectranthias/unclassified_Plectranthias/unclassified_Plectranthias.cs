using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Plectranthias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Plectranthias.unclassified_Plectranthias;

/// <summary>
/// Abstract class for unclassified Plectranthias (no rank).
/// NCBI TaxId: 2677673
/// </summary>
public abstract class unclassified_Plectranthias : Plectranthias, Iunclassified_Plectranthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plectranthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677673;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plectranthias";
}
