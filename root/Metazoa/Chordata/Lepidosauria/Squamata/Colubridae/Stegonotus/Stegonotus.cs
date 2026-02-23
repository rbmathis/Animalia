using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Stegonotus;

/// <summary>
/// Abstract class for Stegonotus (genus).
/// NCBI TaxId: 474073
/// </summary>
public abstract class Stegonotus : Colubridae, IStegonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stegonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 474073;

    /// <inheritdoc />
    public virtual string GenusName => "Stegonotus";

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
