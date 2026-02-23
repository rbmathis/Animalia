using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Colubridae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Colubridae_incertae_sedis.Blythia;

/// <summary>
/// Abstract class for Blythia (genus).
/// NCBI TaxId: 1540812
/// </summary>
public abstract class Blythia : Colubridae_incertae_sedis, IBlythia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Blythia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1540812;

    /// <inheritdoc />
    public virtual string GenusName => "Blythia";

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
