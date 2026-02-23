using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tragulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tragulidae.Tragulus;

/// <summary>
/// Abstract class for Tragulus (genus).
/// NCBI TaxId: 9847
/// </summary>
public abstract class Tragulus : Tragulidae, ITragulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tragulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9847;

    /// <inheritdoc />
    public virtual string GenusName => "Tragulus";

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
