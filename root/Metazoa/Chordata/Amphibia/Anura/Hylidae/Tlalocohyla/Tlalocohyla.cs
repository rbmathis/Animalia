using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Tlalocohyla;

/// <summary>
/// Abstract class for Tlalocohyla (genus).
/// NCBI TaxId: 374085
/// </summary>
public abstract class Tlalocohyla : Hylidae, ITlalocohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tlalocohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374085;

    /// <inheritdoc />
    public virtual string GenusName => "Tlalocohyla";

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
