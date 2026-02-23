using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Monodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Monodontidae.Monodon;

/// <summary>
/// Abstract class for Monodon (genus).
/// NCBI TaxId: 40150
/// </summary>
public abstract class Monodon : Monodontidae, IMonodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40150;

    /// <inheritdoc />
    public virtual string GenusName => "Monodon";

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
