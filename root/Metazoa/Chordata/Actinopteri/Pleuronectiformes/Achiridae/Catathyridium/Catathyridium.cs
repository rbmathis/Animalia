using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae.Catathyridium;

/// <summary>
/// Abstract class for Catathyridium (genus).
/// NCBI TaxId: 329468
/// </summary>
public abstract class Catathyridium : Achiridae, ICatathyridium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Catathyridium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329468;

    /// <inheritdoc />
    public virtual string GenusName => "Catathyridium";

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
