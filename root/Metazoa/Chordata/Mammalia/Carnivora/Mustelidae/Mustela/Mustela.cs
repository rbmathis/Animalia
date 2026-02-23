using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Mustela;

/// <summary>
/// Abstract class for Mustela (genus).
/// NCBI TaxId: 9665
/// </summary>
public abstract class Mustela : Mustelidae, IMustela
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mustela";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9665;

    /// <inheritdoc />
    public virtual string GenusName => "Mustela";

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
