using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Lontra;

/// <summary>
/// Abstract class for Lontra (genus).
/// NCBI TaxId: 71112
/// </summary>
public abstract class Lontra : Mustelidae, ILontra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lontra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71112;

    /// <inheritdoc />
    public virtual string GenusName => "Lontra";

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
