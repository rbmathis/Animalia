using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peramelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peramelidae.Macrotis;

/// <summary>
/// Abstract class for Macrotis (genus).
/// NCBI TaxId: 92650
/// </summary>
public abstract class Macrotis : Peramelidae, IMacrotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 92650;

    /// <inheritdoc />
    public virtual string GenusName => "Macrotis";

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
