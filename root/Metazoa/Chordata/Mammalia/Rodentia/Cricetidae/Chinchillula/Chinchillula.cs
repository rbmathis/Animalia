using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Chinchillula;

/// <summary>
/// Abstract class for Chinchillula (genus).
/// NCBI TaxId: 1258721
/// </summary>
public abstract class Chinchillula : Cricetidae, IChinchillula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chinchillula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1258721;

    /// <inheritdoc />
    public virtual string GenusName => "Chinchillula";

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
