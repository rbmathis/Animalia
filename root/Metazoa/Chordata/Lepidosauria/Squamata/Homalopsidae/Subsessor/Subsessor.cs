using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Subsessor;

/// <summary>
/// Abstract class for Subsessor (genus).
/// NCBI TaxId: 2230912
/// </summary>
public abstract class Subsessor : Homalopsidae, ISubsessor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Subsessor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2230912;

    /// <inheritdoc />
    public virtual string GenusName => "Subsessor";

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
