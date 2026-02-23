using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae.Elephantulus;

/// <summary>
/// Abstract class for Elephantulus (genus).
/// NCBI TaxId: 28736
/// </summary>
public abstract class Elephantulus : Macroscelididae, IElephantulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elephantulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28736;

    /// <inheritdoc />
    public virtual string GenusName => "Elephantulus";

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
