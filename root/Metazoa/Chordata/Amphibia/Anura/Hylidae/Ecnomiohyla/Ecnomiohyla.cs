using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Ecnomiohyla;

/// <summary>
/// Abstract class for Ecnomiohyla (genus).
/// NCBI TaxId: 374081
/// </summary>
public abstract class Ecnomiohyla : Hylidae, IEcnomiohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ecnomiohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374081;

    /// <inheritdoc />
    public virtual string GenusName => "Ecnomiohyla";

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
