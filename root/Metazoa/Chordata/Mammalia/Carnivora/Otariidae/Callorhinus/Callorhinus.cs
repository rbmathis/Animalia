using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae.Callorhinus;

/// <summary>
/// Abstract class for Callorhinus (genus).
/// NCBI TaxId: 34883
/// </summary>
public abstract class Callorhinus : Otariidae, ICallorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34883;

    /// <inheritdoc />
    public virtual string GenusName => "Callorhinus";

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
