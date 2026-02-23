using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Rheithrosciurus;

/// <summary>
/// Abstract class for Rheithrosciurus (genus).
/// NCBI TaxId: 226834
/// </summary>
public abstract class Rheithrosciurus : Sciuridae, IRheithrosciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rheithrosciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226834;

    /// <inheritdoc />
    public virtual string GenusName => "Rheithrosciurus";

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
