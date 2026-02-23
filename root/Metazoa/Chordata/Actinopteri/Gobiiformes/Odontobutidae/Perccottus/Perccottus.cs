using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Odontobutidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Odontobutidae.Perccottus;

/// <summary>
/// Abstract class for Perccottus (genus).
/// NCBI TaxId: 284584
/// </summary>
public abstract class Perccottus : Odontobutidae, IPerccottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Perccottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 284584;

    /// <inheritdoc />
    public virtual string GenusName => "Perccottus";

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
