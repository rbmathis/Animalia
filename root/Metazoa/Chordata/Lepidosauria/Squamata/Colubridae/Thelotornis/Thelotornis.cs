using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Thelotornis;

/// <summary>
/// Abstract class for Thelotornis (genus).
/// NCBI TaxId: 186608
/// </summary>
public abstract class Thelotornis : Colubridae, IThelotornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thelotornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186608;

    /// <inheritdoc />
    public virtual string GenusName => "Thelotornis";

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
