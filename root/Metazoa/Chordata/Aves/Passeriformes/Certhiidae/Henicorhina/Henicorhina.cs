using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Henicorhina;

/// <summary>
/// Abstract class for Henicorhina (genus).
/// NCBI TaxId: 109453
/// </summary>
public abstract class Henicorhina : Certhiidae, IHenicorhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Henicorhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109453;

    /// <inheritdoc />
    public virtual string GenusName => "Henicorhina";

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
