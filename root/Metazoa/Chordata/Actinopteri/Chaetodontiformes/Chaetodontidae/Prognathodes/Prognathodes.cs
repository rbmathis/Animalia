using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Prognathodes;

/// <summary>
/// Abstract class for Prognathodes (genus).
/// NCBI TaxId: 466149
/// </summary>
public abstract class Prognathodes : Chaetodontidae, IPrognathodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prognathodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 466149;

    /// <inheritdoc />
    public virtual string GenusName => "Prognathodes";

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
