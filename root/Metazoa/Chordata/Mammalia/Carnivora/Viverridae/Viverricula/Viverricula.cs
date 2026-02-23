using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Viverricula;

/// <summary>
/// Abstract class for Viverricula (genus).
/// NCBI TaxId: 94195
/// </summary>
public abstract class Viverricula : Viverridae, IViverricula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Viverricula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94195;

    /// <inheritdoc />
    public virtual string GenusName => "Viverricula";

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
