using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Notoliparis;

/// <summary>
/// Abstract class for Notoliparis (genus).
/// NCBI TaxId: 2059684
/// </summary>
public abstract class Notoliparis : Liparidae, INotoliparis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notoliparis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2059684;

    /// <inheritdoc />
    public virtual string GenusName => "Notoliparis";

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
