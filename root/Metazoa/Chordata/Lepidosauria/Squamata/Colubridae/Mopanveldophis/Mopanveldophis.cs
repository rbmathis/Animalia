using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Mopanveldophis;

/// <summary>
/// Abstract class for Mopanveldophis (genus).
/// NCBI TaxId: 2184520
/// </summary>
public abstract class Mopanveldophis : Colubridae, IMopanveldophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mopanveldophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2184520;

    /// <inheritdoc />
    public virtual string GenusName => "Mopanveldophis";

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
