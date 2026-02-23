using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Mammuthus;

/// <summary>
/// Abstract class for Mammuthus (genus).
/// NCBI TaxId: 37348
/// </summary>
public abstract class Mammuthus : Elephantidae, IMammuthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mammuthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37348;

    /// <inheritdoc />
    public virtual string GenusName => "Mammuthus";

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
