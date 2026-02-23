using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Paradoxurus;

/// <summary>
/// Abstract class for Paradoxurus (genus).
/// NCBI TaxId: 71116
/// </summary>
public abstract class Paradoxurus : Viverridae, IParadoxurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paradoxurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71116;

    /// <inheritdoc />
    public virtual string GenusName => "Paradoxurus";

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
