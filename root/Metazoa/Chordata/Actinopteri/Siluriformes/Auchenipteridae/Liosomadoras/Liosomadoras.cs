using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Liosomadoras;

/// <summary>
/// Abstract class for Liosomadoras (genus).
/// NCBI TaxId: 238675
/// </summary>
public abstract class Liosomadoras : Auchenipteridae, ILiosomadoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liosomadoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238675;

    /// <inheritdoc />
    public virtual string GenusName => "Liosomadoras";

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
