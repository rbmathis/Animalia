using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Cryptotis;

/// <summary>
/// Abstract class for Cryptotis (genus).
/// NCBI TaxId: 183660
/// </summary>
public abstract class Cryptotis : Soricidae, ICryptotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183660;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptotis";

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
