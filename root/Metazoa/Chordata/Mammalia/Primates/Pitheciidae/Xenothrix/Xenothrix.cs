using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Xenothrix;

/// <summary>
/// Abstract class for Xenothrix (genus).
/// NCBI TaxId: 2490930
/// </summary>
public abstract class Xenothrix : Pitheciidae, IXenothrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenothrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2490930;

    /// <inheritdoc />
    public virtual string GenusName => "Xenothrix";

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
