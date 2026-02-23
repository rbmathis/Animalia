using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Megastomatohyla;

/// <summary>
/// Abstract class for Megastomatohyla (genus).
/// NCBI TaxId: 374084
/// </summary>
public abstract class Megastomatohyla : Hylidae, IMegastomatohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megastomatohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374084;

    /// <inheritdoc />
    public virtual string GenusName => "Megastomatohyla";

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
