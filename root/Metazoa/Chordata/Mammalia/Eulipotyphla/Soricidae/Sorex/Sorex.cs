using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Sorex;

/// <summary>
/// Abstract class for Sorex (genus).
/// NCBI TaxId: 9379
/// </summary>
public abstract class Sorex : Soricidae, ISorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9379;

    /// <inheritdoc />
    public virtual string GenusName => "Sorex";

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
