using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Telmatherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Telmatherinidae.Kalyptatherina;

/// <summary>
/// Abstract class for Kalyptatherina (genus).
/// NCBI TaxId: 1498635
/// </summary>
public abstract class Kalyptatherina : Telmatherinidae, IKalyptatherina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kalyptatherina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1498635;

    /// <inheritdoc />
    public virtual string GenusName => "Kalyptatherina";

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
