using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Pseudoliparis;

/// <summary>
/// Abstract class for Pseudoliparis (genus).
/// NCBI TaxId: 2059683
/// </summary>
public abstract class Pseudoliparis : Liparidae, IPseudoliparis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoliparis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2059683;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoliparis";

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
