using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Chinchillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Chinchillidae.Chinchilla;

/// <summary>
/// Abstract class for Chinchilla (genus).
/// NCBI TaxId: 10151
/// </summary>
public abstract class Chinchilla : Chinchillidae, IChinchilla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chinchilla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10151;

    /// <inheritdoc />
    public virtual string GenusName => "Chinchilla";

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
