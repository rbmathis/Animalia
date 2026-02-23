using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Chelmon;

/// <summary>
/// Abstract class for Chelmon (genus).
/// NCBI TaxId: 109904
/// </summary>
public abstract class Chelmon : Chaetodontidae, IChelmon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelmon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109904;

    /// <inheritdoc />
    public virtual string GenusName => "Chelmon";

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
