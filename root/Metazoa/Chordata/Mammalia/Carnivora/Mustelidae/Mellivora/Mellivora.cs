using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Mellivora;

/// <summary>
/// Abstract class for Mellivora (genus).
/// NCBI TaxId: 9663
/// </summary>
public abstract class Mellivora : Mustelidae, IMellivora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mellivora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9663;

    /// <inheritdoc />
    public virtual string GenusName => "Mellivora";

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
