using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae.Phanerodon;

/// <summary>
/// Abstract class for Phanerodon (genus).
/// NCBI TaxId: 100199
/// </summary>
public abstract class Phanerodon : Embiotocidae, IPhanerodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phanerodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 100199;

    /// <inheritdoc />
    public virtual string GenusName => "Phanerodon";

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
