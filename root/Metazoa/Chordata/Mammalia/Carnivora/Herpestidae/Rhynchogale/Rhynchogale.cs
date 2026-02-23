using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Rhynchogale;

/// <summary>
/// Abstract class for Rhynchogale (genus).
/// NCBI TaxId: 210653
/// </summary>
public abstract class Rhynchogale : Herpestidae, IRhynchogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210653;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchogale";

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
