using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Coradion;

/// <summary>
/// Abstract class for Coradion (genus).
/// NCBI TaxId: 109906
/// </summary>
public abstract class Coradion : Chaetodontidae, ICoradion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coradion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109906;

    /// <inheritdoc />
    public virtual string GenusName => "Coradion";

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
