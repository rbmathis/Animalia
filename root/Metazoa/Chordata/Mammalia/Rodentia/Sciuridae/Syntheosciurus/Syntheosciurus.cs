using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Syntheosciurus;

/// <summary>
/// Abstract class for Syntheosciurus (genus).
/// NCBI TaxId: 226840
/// </summary>
public abstract class Syntheosciurus : Sciuridae, ISyntheosciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Syntheosciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226840;

    /// <inheritdoc />
    public virtual string GenusName => "Syntheosciurus";

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
