using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae.Hyperoglyphe;

/// <summary>
/// Abstract class for Hyperoglyphe (genus).
/// NCBI TaxId: 171195
/// </summary>
public abstract class Hyperoglyphe : Centrolophidae, IHyperoglyphe
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyperoglyphe";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 171195;

    /// <inheritdoc />
    public virtual string GenusName => "Hyperoglyphe";

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
