using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Psedoliparis;

/// <summary>
/// Abstract class for Psedoliparis (genus).
/// NCBI TaxId: 2936621
/// </summary>
public abstract class Psedoliparis : Liparidae, IPsedoliparis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psedoliparis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2936621;

    /// <inheritdoc />
    public virtual string GenusName => "Psedoliparis";

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
