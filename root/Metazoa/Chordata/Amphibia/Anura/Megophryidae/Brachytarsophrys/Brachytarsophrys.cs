using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Brachytarsophrys;

/// <summary>
/// Abstract class for Brachytarsophrys (genus).
/// NCBI TaxId: 233774
/// </summary>
public abstract class Brachytarsophrys : Megophryidae, IBrachytarsophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachytarsophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 233774;

    /// <inheritdoc />
    public virtual string GenusName => "Brachytarsophrys";

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
