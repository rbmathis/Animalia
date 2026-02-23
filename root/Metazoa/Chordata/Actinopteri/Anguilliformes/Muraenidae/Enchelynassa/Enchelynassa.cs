using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Enchelynassa;

/// <summary>
/// Abstract class for Enchelynassa (genus).
/// NCBI TaxId: 876646
/// </summary>
public abstract class Enchelynassa : Muraenidae, IEnchelynassa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enchelynassa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 876646;

    /// <inheritdoc />
    public virtual string GenusName => "Enchelynassa";

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
