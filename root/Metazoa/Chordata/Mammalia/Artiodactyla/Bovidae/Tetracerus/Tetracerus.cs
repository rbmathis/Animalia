using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Tetracerus;

/// <summary>
/// Abstract class for Tetracerus (genus).
/// NCBI TaxId: 73822
/// </summary>
public abstract class Tetracerus : Bovidae, ITetracerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetracerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 73822;

    /// <inheritdoc />
    public virtual string GenusName => "Tetracerus";

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
