using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Tamiasciurus;

/// <summary>
/// Abstract class for Tamiasciurus (genus).
/// NCBI TaxId: 10008
/// </summary>
public abstract class Tamiasciurus : Sciuridae, ITamiasciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tamiasciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10008;

    /// <inheritdoc />
    public virtual string GenusName => "Tamiasciurus";

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
