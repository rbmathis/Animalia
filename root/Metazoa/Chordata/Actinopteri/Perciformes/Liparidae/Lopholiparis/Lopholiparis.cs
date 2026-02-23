using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Lopholiparis;

/// <summary>
/// Abstract class for Lopholiparis (genus).
/// NCBI TaxId: 1696911
/// </summary>
public abstract class Lopholiparis : Liparidae, ILopholiparis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lopholiparis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1696911;

    /// <inheritdoc />
    public virtual string GenusName => "Lopholiparis";

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
