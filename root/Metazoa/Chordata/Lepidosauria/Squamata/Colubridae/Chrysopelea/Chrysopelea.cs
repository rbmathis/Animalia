using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Chrysopelea;

/// <summary>
/// Abstract class for Chrysopelea (genus).
/// NCBI TaxId: 699570
/// </summary>
public abstract class Chrysopelea : Colubridae, IChrysopelea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysopelea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 699570;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysopelea";

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
