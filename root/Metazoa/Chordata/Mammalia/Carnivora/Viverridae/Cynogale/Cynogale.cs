using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Cynogale;

/// <summary>
/// Abstract class for Cynogale (genus).
/// NCBI TaxId: 395838
/// </summary>
public abstract class Cynogale : Viverridae, ICynogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cynogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 395838;

    /// <inheritdoc />
    public virtual string GenusName => "Cynogale";

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
