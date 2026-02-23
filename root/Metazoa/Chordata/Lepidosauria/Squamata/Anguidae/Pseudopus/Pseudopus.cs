using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Pseudopus;

/// <summary>
/// Abstract class for Pseudopus (genus).
/// NCBI TaxId: 672773
/// </summary>
public abstract class Pseudopus : Anguidae, IPseudopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 672773;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudopus";

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
