using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Jingophrys;

/// <summary>
/// Abstract class for Jingophrys (genus).
/// NCBI TaxId: 3035846
/// </summary>
public abstract class Jingophrys : Megophryidae, IJingophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jingophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3035846;

    /// <inheritdoc />
    public virtual string GenusName => "Jingophrys";

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
