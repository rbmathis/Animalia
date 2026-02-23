using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Desmodilliscus;

/// <summary>
/// Abstract class for Desmodilliscus (genus).
/// NCBI TaxId: 298891
/// </summary>
public abstract class Desmodilliscus : Muridae, IDesmodilliscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Desmodilliscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 298891;

    /// <inheritdoc />
    public virtual string GenusName => "Desmodilliscus";

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
