using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Eremophilus;

/// <summary>
/// Abstract class for Eremophilus (genus).
/// NCBI TaxId: 2023055
/// </summary>
public abstract class Eremophilus : Trichomycteridae, IEremophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eremophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2023055;

    /// <inheritdoc />
    public virtual string GenusName => "Eremophilus";

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
