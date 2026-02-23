using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Phyllomedusa;

/// <summary>
/// Abstract class for Phyllomedusa (genus).
/// NCBI TaxId: 8392
/// </summary>
public abstract class Phyllomedusa : Hylidae, IPhyllomedusa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllomedusa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8392;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllomedusa";

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
