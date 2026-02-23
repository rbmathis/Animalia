using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crossogale;

/// <summary>
/// Abstract class for Crossogale (genus).
/// NCBI TaxId: 2747558
/// </summary>
public abstract class Crossogale : Soricidae, ICrossogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crossogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2747558;

    /// <inheritdoc />
    public virtual string GenusName => "Crossogale";

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
