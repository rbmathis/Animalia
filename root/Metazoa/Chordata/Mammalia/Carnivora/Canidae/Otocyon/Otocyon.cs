using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Otocyon;

/// <summary>
/// Abstract class for Otocyon (genus).
/// NCBI TaxId: 9623
/// </summary>
public abstract class Otocyon : Canidae, IOtocyon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otocyon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9623;

    /// <inheritdoc />
    public virtual string GenusName => "Otocyon";

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
