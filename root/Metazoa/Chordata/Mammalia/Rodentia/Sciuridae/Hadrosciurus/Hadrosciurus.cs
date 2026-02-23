using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Hadrosciurus;

/// <summary>
/// Abstract class for Hadrosciurus (genus).
/// NCBI TaxId: 2749099
/// </summary>
public abstract class Hadrosciurus : Sciuridae, IHadrosciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hadrosciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2749099;

    /// <inheritdoc />
    public virtual string GenusName => "Hadrosciurus";

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
