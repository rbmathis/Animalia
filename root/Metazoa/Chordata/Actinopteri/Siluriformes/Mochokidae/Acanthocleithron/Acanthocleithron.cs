using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Acanthocleithron;

/// <summary>
/// Abstract class for Acanthocleithron (genus).
/// NCBI TaxId: 1677043
/// </summary>
public abstract class Acanthocleithron : Mochokidae, IAcanthocleithron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthocleithron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1677043;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthocleithron";

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
