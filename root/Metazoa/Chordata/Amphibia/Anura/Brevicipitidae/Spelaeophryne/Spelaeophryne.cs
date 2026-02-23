using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae.Spelaeophryne;

/// <summary>
/// Abstract class for Spelaeophryne (genus).
/// NCBI TaxId: 274523
/// </summary>
public abstract class Spelaeophryne : Brevicipitidae, ISpelaeophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spelaeophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274523;

    /// <inheritdoc />
    public virtual string GenusName => "Spelaeophryne";

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
