using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Chonerhinos;

/// <summary>
/// Abstract class for Chonerhinos (genus).
/// NCBI TaxId: 1329252
/// </summary>
public abstract class Chonerhinos : Tetraodontidae, IChonerhinos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chonerhinos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1329252;

    /// <inheritdoc />
    public virtual string GenusName => "Chonerhinos";

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
