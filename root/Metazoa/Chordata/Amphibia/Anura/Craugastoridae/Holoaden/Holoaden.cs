using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Holoaden;

/// <summary>
/// Abstract class for Holoaden (genus).
/// NCBI TaxId: 449229
/// </summary>
public abstract class Holoaden : Craugastoridae, IHoloaden
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Holoaden";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 449229;

    /// <inheritdoc />
    public virtual string GenusName => "Holoaden";

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
