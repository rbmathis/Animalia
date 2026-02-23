using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Amphiesmoides;

/// <summary>
/// Abstract class for Amphiesmoides (genus).
/// NCBI TaxId: 1539387
/// </summary>
public abstract class Amphiesmoides : Colubridae, IAmphiesmoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amphiesmoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1539387;

    /// <inheritdoc />
    public virtual string GenusName => "Amphiesmoides";

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
