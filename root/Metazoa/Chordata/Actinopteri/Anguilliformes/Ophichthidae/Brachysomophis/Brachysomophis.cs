using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Brachysomophis;

/// <summary>
/// Abstract class for Brachysomophis (genus).
/// NCBI TaxId: 391183
/// </summary>
public abstract class Brachysomophis : Ophichthidae, IBrachysomophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachysomophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 391183;

    /// <inheritdoc />
    public virtual string GenusName => "Brachysomophis";

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
