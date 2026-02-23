using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Naultinus;

/// <summary>
/// Abstract class for Naultinus (genus).
/// NCBI TaxId: 946315
/// </summary>
public abstract class Naultinus : Diplodactylidae, INaultinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Naultinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 946315;

    /// <inheritdoc />
    public virtual string GenusName => "Naultinus";

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
