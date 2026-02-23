using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae.Gerrhosaurus;

/// <summary>
/// Abstract class for Gerrhosaurus (genus).
/// NCBI TaxId: 126621
/// </summary>
public abstract class Gerrhosaurus : Gerrhosauridae, IGerrhosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gerrhosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126621;

    /// <inheritdoc />
    public virtual string GenusName => "Gerrhosaurus";

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
