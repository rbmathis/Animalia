using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Sarotherodon;

/// <summary>
/// Abstract class for Sarotherodon (genus).
/// NCBI TaxId: 8143
/// </summary>
public abstract class Sarotherodon : Cichlidae, ISarotherodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sarotherodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8143;

    /// <inheritdoc />
    public virtual string GenusName => "Sarotherodon";

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
