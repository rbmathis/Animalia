using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Sekeetamys;

/// <summary>
/// Abstract class for Sekeetamys (genus).
/// NCBI TaxId: 298883
/// </summary>
public abstract class Sekeetamys : Muridae, ISekeetamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sekeetamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 298883;

    /// <inheritdoc />
    public virtual string GenusName => "Sekeetamys";

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
