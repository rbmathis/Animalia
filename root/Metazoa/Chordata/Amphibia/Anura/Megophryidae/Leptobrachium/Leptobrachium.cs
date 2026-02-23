using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Leptobrachium;

/// <summary>
/// Abstract class for Leptobrachium (genus).
/// NCBI TaxId: 161697
/// </summary>
public abstract class Leptobrachium : Megophryidae, ILeptobrachium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptobrachium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161697;

    /// <inheritdoc />
    public virtual string GenusName => "Leptobrachium";

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
