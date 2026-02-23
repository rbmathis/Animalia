using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Paraliparis;

/// <summary>
/// Abstract class for Paraliparis (genus).
/// NCBI TaxId: 446821
/// </summary>
public abstract class Paraliparis : Liparidae, IParaliparis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraliparis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 446821;

    /// <inheritdoc />
    public virtual string GenusName => "Paraliparis";

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
