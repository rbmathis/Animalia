using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Moschidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Moschidae.Moschus;

/// <summary>
/// Abstract class for Moschus (genus).
/// NCBI TaxId: 68410
/// </summary>
public abstract class Moschus : Moschidae, IMoschus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Moschus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68410;

    /// <inheritdoc />
    public virtual string GenusName => "Moschus";

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
