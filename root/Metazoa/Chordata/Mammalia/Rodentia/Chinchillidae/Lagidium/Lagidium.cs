using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Chinchillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Chinchillidae.Lagidium;

/// <summary>
/// Abstract class for Lagidium (genus).
/// NCBI TaxId: 84622
/// </summary>
public abstract class Lagidium : Chinchillidae, ILagidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lagidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84622;

    /// <inheritdoc />
    public virtual string GenusName => "Lagidium";

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
