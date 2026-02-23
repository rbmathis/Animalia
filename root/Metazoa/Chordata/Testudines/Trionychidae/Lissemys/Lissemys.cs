using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Lissemys;

/// <summary>
/// Abstract class for Lissemys (genus).
/// NCBI TaxId: 55541
/// </summary>
public abstract class Lissemys : Trionychidae, ILissemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lissemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55541;

    /// <inheritdoc />
    public virtual string GenusName => "Lissemys";

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
