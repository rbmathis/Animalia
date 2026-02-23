using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Callimedusa;

/// <summary>
/// Abstract class for Callimedusa (genus).
/// NCBI TaxId: 2697829
/// </summary>
public abstract class Callimedusa : Hylidae, ICallimedusa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callimedusa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2697829;

    /// <inheritdoc />
    public virtual string GenusName => "Callimedusa";

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
