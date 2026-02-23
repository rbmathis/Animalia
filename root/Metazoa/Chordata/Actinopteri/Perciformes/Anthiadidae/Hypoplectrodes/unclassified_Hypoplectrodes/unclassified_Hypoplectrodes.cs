using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Hypoplectrodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Hypoplectrodes.unclassified_Hypoplectrodes;

/// <summary>
/// Abstract class for unclassified Hypoplectrodes (no rank).
/// NCBI TaxId: 2696555
/// </summary>
public abstract class unclassified_Hypoplectrodes : Hypoplectrodes, Iunclassified_Hypoplectrodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypoplectrodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696555;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypoplectrodes";
}
