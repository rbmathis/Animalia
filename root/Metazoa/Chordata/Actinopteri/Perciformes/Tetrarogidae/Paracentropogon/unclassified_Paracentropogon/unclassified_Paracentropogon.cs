using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Paracentropogon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Paracentropogon.unclassified_Paracentropogon;

/// <summary>
/// Abstract class for unclassified Paracentropogon (no rank).
/// NCBI TaxId: 3122081
/// </summary>
public abstract class unclassified_Paracentropogon : Paracentropogon, Iunclassified_Paracentropogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paracentropogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3122081;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paracentropogon";
}
