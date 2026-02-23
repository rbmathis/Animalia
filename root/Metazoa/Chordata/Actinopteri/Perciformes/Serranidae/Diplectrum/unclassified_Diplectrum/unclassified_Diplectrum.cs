using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Diplectrum;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Diplectrum.unclassified_Diplectrum;

/// <summary>
/// Abstract class for unclassified Diplectrum (no rank).
/// NCBI TaxId: 2619988
/// </summary>
public abstract class unclassified_Diplectrum : Diplectrum, Iunclassified_Diplectrum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diplectrum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619988;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diplectrum";
}
