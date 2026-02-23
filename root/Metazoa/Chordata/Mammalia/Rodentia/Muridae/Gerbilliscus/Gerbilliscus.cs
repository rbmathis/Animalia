using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Gerbilliscus;

/// <summary>
/// Abstract class for Gerbilliscus (genus).
/// NCBI TaxId: 410297
/// </summary>
public abstract class Gerbilliscus : Muridae, IGerbilliscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gerbilliscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 410297;

    /// <inheritdoc />
    public virtual string GenusName => "Gerbilliscus";

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
