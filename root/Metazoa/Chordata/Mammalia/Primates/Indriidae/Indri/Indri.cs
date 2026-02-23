using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Indri;

/// <summary>
/// Abstract class for Indri (genus).
/// NCBI TaxId: 34826
/// </summary>
public abstract class Indri : Indriidae, IIndri
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Indri";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34826;

    /// <inheritdoc />
    public virtual string GenusName => "Indri";

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
