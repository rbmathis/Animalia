using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Margaretamys;

/// <summary>
/// Abstract class for Margaretamys (genus).
/// NCBI TaxId: 1392619
/// </summary>
public abstract class Margaretamys : Muridae, IMargaretamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Margaretamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1392619;

    /// <inheritdoc />
    public virtual string GenusName => "Margaretamys";

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
