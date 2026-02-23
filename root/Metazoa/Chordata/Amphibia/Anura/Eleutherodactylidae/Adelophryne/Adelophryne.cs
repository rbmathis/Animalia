using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae.Adelophryne;

/// <summary>
/// Abstract class for Adelophryne (genus).
/// NCBI TaxId: 491139
/// </summary>
public abstract class Adelophryne : Eleutherodactylidae, IAdelophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Adelophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 491139;

    /// <inheritdoc />
    public virtual string GenusName => "Adelophryne";

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
