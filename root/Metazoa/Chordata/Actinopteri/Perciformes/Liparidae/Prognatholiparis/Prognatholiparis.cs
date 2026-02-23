using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Prognatholiparis;

/// <summary>
/// Abstract class for Prognatholiparis (genus).
/// NCBI TaxId: 1696915
/// </summary>
public abstract class Prognatholiparis : Liparidae, IPrognatholiparis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prognatholiparis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1696915;

    /// <inheritdoc />
    public virtual string GenusName => "Prognatholiparis";

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
