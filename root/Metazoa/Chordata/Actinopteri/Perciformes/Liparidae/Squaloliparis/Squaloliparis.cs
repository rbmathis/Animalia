using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Squaloliparis;

/// <summary>
/// Abstract class for Squaloliparis (genus).
/// NCBI TaxId: 1642183
/// </summary>
public abstract class Squaloliparis : Liparidae, ISqualoliparis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Squaloliparis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1642183;

    /// <inheritdoc />
    public virtual string GenusName => "Squaloliparis";

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
