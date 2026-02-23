using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae.Trichosurus;

/// <summary>
/// Abstract class for Trichosurus (genus).
/// NCBI TaxId: 9336
/// </summary>
public abstract class Trichosurus : Phalangeridae, ITrichosurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichosurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9336;

    /// <inheritdoc />
    public virtual string GenusName => "Trichosurus";

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
