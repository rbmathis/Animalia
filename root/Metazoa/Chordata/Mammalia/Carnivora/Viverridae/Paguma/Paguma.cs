using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Paguma;

/// <summary>
/// Abstract class for Paguma (genus).
/// NCBI TaxId: 9674
/// </summary>
public abstract class Paguma : Viverridae, IPaguma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paguma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9674;

    /// <inheritdoc />
    public virtual string GenusName => "Paguma";

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
