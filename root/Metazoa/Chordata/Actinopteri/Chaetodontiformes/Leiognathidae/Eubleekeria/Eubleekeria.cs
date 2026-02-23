using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Eubleekeria;

/// <summary>
/// Abstract class for Eubleekeria (genus).
/// NCBI TaxId: 568896
/// </summary>
public abstract class Eubleekeria : Leiognathidae, IEubleekeria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eubleekeria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 568896;

    /// <inheritdoc />
    public virtual string GenusName => "Eubleekeria";

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
