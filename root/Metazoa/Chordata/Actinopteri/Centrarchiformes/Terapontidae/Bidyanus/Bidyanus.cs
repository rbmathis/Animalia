using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Bidyanus;

/// <summary>
/// Abstract class for Bidyanus (genus).
/// NCBI TaxId: 443751
/// </summary>
public abstract class Bidyanus : Terapontidae, IBidyanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bidyanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443751;

    /// <inheritdoc />
    public virtual string GenusName => "Bidyanus";

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
