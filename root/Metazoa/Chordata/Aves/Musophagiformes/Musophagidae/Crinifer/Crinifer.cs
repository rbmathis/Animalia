using AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae.Crinifer;

/// <summary>
/// Abstract class for Crinifer (genus).
/// NCBI TaxId: 119407
/// </summary>
public abstract class Crinifer : Musophagidae, ICrinifer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crinifer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119407;

    /// <inheritdoc />
    public virtual string GenusName => "Crinifer";

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
