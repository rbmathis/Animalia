using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Thrasops;

/// <summary>
/// Abstract class for Thrasops (genus).
/// NCBI TaxId: 186610
/// </summary>
public abstract class Thrasops : Colubridae, IThrasops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thrasops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186610;

    /// <inheritdoc />
    public virtual string GenusName => "Thrasops";

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
