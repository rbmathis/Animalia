using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Barbastella;

/// <summary>
/// Abstract class for Barbastella (genus).
/// NCBI TaxId: 59448
/// </summary>
public abstract class Barbastella : Vespertilionidae, IBarbastella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barbastella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59448;

    /// <inheritdoc />
    public virtual string GenusName => "Barbastella";

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
