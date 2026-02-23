using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Xenophrys;

/// <summary>
/// Abstract class for Xenophrys (genus).
/// NCBI TaxId: 161701
/// </summary>
public abstract class Xenophrys : Megophryidae, IXenophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161701;

    /// <inheritdoc />
    public virtual string GenusName => "Xenophrys";

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
