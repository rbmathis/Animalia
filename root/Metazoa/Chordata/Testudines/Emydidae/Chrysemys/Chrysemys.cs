using AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Chrysemys;

/// <summary>
/// Abstract class for Chrysemys (genus).
/// NCBI TaxId: 8477
/// </summary>
public abstract class Chrysemys : Emydidae, IChrysemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8477;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysemys";

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
