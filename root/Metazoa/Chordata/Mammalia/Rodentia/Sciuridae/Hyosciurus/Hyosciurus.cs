using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Hyosciurus;

/// <summary>
/// Abstract class for Hyosciurus (genus).
/// NCBI TaxId: 226554
/// </summary>
public abstract class Hyosciurus : Sciuridae, IHyosciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyosciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226554;

    /// <inheritdoc />
    public virtual string GenusName => "Hyosciurus";

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
