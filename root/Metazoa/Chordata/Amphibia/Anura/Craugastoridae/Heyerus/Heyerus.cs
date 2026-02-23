using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Heyerus;

/// <summary>
/// Abstract class for Heyerus (genus).
/// NCBI TaxId: 2842250
/// </summary>
public abstract class Heyerus : Craugastoridae, IHeyerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heyerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2842250;

    /// <inheritdoc />
    public virtual string GenusName => "Heyerus";

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
