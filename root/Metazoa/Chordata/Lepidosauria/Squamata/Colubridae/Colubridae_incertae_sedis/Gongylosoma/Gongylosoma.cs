using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Colubridae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Colubridae_incertae_sedis.Gongylosoma;

/// <summary>
/// Abstract class for Gongylosoma (genus).
/// NCBI TaxId: 1544891
/// </summary>
public abstract class Gongylosoma : Colubridae_incertae_sedis, IGongylosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gongylosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544891;

    /// <inheritdoc />
    public virtual string GenusName => "Gongylosoma";

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
