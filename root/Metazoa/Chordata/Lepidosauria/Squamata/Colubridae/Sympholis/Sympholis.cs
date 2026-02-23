using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Sympholis;

/// <summary>
/// Abstract class for Sympholis (genus).
/// NCBI TaxId: 699596
/// </summary>
public abstract class Sympholis : Colubridae, ISympholis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sympholis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 699596;

    /// <inheritdoc />
    public virtual string GenusName => "Sympholis";

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
