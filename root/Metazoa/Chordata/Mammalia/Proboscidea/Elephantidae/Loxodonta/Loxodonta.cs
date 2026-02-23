using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Loxodonta;

/// <summary>
/// Abstract class for Loxodonta (genus).
/// NCBI TaxId: 9784
/// </summary>
public abstract class Loxodonta : Elephantidae, ILoxodonta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loxodonta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9784;

    /// <inheritdoc />
    public virtual string GenusName => "Loxodonta";

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
