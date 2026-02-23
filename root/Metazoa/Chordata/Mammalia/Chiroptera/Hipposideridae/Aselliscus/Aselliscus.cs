using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Hipposideridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Hipposideridae.Aselliscus;

/// <summary>
/// Abstract class for Aselliscus (genus).
/// NCBI TaxId: 188567
/// </summary>
public abstract class Aselliscus : Hipposideridae, IAselliscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aselliscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 188567;

    /// <inheritdoc />
    public virtual string GenusName => "Aselliscus";

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
