using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lorentzimys;

/// <summary>
/// Abstract class for Lorentzimys (genus).
/// NCBI TaxId: 442575
/// </summary>
public abstract class Lorentzimys : Muridae, ILorentzimys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lorentzimys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 442575;

    /// <inheritdoc />
    public virtual string GenusName => "Lorentzimys";

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
