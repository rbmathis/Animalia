using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Pithecia;

/// <summary>
/// Abstract class for Pithecia (genus).
/// NCBI TaxId: 30597
/// </summary>
public abstract class Pithecia : Pitheciidae, IPithecia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pithecia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30597;

    /// <inheritdoc />
    public virtual string GenusName => "Pithecia";

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
