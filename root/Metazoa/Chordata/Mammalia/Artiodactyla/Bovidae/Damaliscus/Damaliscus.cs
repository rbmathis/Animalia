using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Damaliscus;

/// <summary>
/// Abstract class for Damaliscus (genus).
/// NCBI TaxId: 9928
/// </summary>
public abstract class Damaliscus : Bovidae, IDamaliscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Damaliscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9928;

    /// <inheritdoc />
    public virtual string GenusName => "Damaliscus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
