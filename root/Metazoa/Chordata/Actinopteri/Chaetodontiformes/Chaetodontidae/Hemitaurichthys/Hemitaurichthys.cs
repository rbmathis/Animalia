using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Hemitaurichthys;

/// <summary>
/// Abstract class for Hemitaurichthys (genus).
/// NCBI TaxId: 109913
/// </summary>
public abstract class Hemitaurichthys : Chaetodontidae, IHemitaurichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemitaurichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109913;

    /// <inheritdoc />
    public virtual string GenusName => "Hemitaurichthys";

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
