using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Acantholiparis;

/// <summary>
/// Abstract class for Acantholiparis (genus).
/// NCBI TaxId: 557402
/// </summary>
public abstract class Acantholiparis : Liparidae, IAcantholiparis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acantholiparis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 557402;

    /// <inheritdoc />
    public virtual string GenusName => "Acantholiparis";

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
