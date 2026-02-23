using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae.Phyzelaphryne;

/// <summary>
/// Abstract class for Phyzelaphryne (genus).
/// NCBI TaxId: 491157
/// </summary>
public abstract class Phyzelaphryne : Eleutherodactylidae, IPhyzelaphryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyzelaphryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 491157;

    /// <inheritdoc />
    public virtual string GenusName => "Phyzelaphryne";

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
