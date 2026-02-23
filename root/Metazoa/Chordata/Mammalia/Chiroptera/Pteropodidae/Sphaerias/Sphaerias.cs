using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Sphaerias;

/// <summary>
/// Abstract class for Sphaerias (genus).
/// NCBI TaxId: 662897
/// </summary>
public abstract class Sphaerias : Pteropodidae, ISphaerias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphaerias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 662897;

    /// <inheritdoc />
    public virtual string GenusName => "Sphaerias";

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
