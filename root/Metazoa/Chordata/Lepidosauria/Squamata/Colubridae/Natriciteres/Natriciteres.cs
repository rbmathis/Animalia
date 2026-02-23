using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Natriciteres;

/// <summary>
/// Abstract class for Natriciteres (genus).
/// NCBI TaxId: 186587
/// </summary>
public abstract class Natriciteres : Colubridae, INatriciteres
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Natriciteres";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186587;

    /// <inheritdoc />
    public virtual string GenusName => "Natriciteres";

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
