using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Roa;

/// <summary>
/// Abstract class for Roa (genus).
/// NCBI TaxId: 1510180
/// </summary>
public abstract class Roa : Chaetodontidae, IRoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Roa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1510180;

    /// <inheritdoc />
    public virtual string GenusName => "Roa";

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
