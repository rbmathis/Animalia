using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Zamenis;

/// <summary>
/// Abstract class for Zamenis (genus).
/// NCBI TaxId: 201437
/// </summary>
public abstract class Zamenis : Colubridae, IZamenis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zamenis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201437;

    /// <inheritdoc />
    public virtual string GenusName => "Zamenis";

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
