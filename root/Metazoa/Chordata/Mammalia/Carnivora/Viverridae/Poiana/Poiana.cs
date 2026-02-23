using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Poiana;

/// <summary>
/// Abstract class for Poiana (genus).
/// NCBI TaxId: 205653
/// </summary>
public abstract class Poiana : Viverridae, IPoiana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poiana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 205653;

    /// <inheritdoc />
    public virtual string GenusName => "Poiana";

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
