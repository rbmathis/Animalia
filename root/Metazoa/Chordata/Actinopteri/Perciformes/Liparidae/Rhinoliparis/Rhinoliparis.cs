using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Rhinoliparis;

/// <summary>
/// Abstract class for Rhinoliparis (genus).
/// NCBI TaxId: 446836
/// </summary>
public abstract class Rhinoliparis : Liparidae, IRhinoliparis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinoliparis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 446836;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinoliparis";

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
