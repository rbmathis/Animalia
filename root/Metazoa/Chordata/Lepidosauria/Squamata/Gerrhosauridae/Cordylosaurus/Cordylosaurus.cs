using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae.Cordylosaurus;

/// <summary>
/// Abstract class for Cordylosaurus (genus).
/// NCBI TaxId: 219624
/// </summary>
public abstract class Cordylosaurus : Gerrhosauridae, ICordylosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cordylosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 219624;

    /// <inheritdoc />
    public virtual string GenusName => "Cordylosaurus";

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
