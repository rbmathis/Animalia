using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Hemorrhois;

/// <summary>
/// Abstract class for Hemorrhois (genus).
/// NCBI TaxId: 166081
/// </summary>
public abstract class Hemorrhois : Colubridae, IHemorrhois
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemorrhois";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166081;

    /// <inheritdoc />
    public virtual string GenusName => "Hemorrhois";

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
