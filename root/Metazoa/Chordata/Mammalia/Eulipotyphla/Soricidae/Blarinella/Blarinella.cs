using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Blarinella;

/// <summary>
/// Abstract class for Blarinella (genus).
/// NCBI TaxId: 202265
/// </summary>
public abstract class Blarinella : Soricidae, IBlarinella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Blarinella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 202265;

    /// <inheritdoc />
    public virtual string GenusName => "Blarinella";

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
