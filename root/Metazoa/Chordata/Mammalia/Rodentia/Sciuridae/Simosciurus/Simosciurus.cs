using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Simosciurus;

/// <summary>
/// Abstract class for Simosciurus (genus).
/// NCBI TaxId: 2749100
/// </summary>
public abstract class Simosciurus : Sciuridae, ISimosciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Simosciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2749100;

    /// <inheritdoc />
    public virtual string GenusName => "Simosciurus";

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
