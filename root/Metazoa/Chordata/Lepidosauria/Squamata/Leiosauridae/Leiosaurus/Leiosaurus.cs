using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leiosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leiosauridae.Leiosaurus;

/// <summary>
/// Abstract class for Leiosaurus (genus).
/// NCBI TaxId: 161145
/// </summary>
public abstract class Leiosaurus : Leiosauridae, ILeiosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161145;

    /// <inheritdoc />
    public virtual string GenusName => "Leiosaurus";

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
