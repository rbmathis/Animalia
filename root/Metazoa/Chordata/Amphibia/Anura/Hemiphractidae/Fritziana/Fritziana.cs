using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Fritziana;

/// <summary>
/// Abstract class for Fritziana (genus).
/// NCBI TaxId: 1171662
/// </summary>
public abstract class Fritziana : Hemiphractidae, IFritziana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fritziana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1171662;

    /// <inheritdoc />
    public virtual string GenusName => "Fritziana";

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
