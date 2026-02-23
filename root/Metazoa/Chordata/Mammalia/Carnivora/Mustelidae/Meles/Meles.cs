using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Meles;

/// <summary>
/// Abstract class for Meles (genus).
/// NCBI TaxId: 9661
/// </summary>
public abstract class Meles : Mustelidae, IMeles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Meles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9661;

    /// <inheritdoc />
    public virtual string GenusName => "Meles";

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
