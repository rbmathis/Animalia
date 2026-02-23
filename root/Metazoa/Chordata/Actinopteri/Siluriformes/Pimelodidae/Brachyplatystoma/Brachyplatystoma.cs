using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Brachyplatystoma;

/// <summary>
/// Abstract class for Brachyplatystoma (genus).
/// NCBI TaxId: 337631
/// </summary>
public abstract class Brachyplatystoma : Pimelodidae, IBrachyplatystoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachyplatystoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337631;

    /// <inheritdoc />
    public virtual string GenusName => "Brachyplatystoma";

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
