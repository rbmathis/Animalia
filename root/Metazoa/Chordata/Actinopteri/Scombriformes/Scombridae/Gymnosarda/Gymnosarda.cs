using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Gymnosarda;

/// <summary>
/// Abstract class for Gymnosarda (genus).
/// NCBI TaxId: 372804
/// </summary>
public abstract class Gymnosarda : Scombridae, IGymnosarda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnosarda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 372804;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnosarda";

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
