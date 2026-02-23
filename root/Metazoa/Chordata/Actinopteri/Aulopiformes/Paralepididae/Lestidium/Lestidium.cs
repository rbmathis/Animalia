using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Lestidium;

/// <summary>
/// Abstract class for Lestidium (genus).
/// NCBI TaxId: 172139
/// </summary>
public abstract class Lestidium : Paralepididae, ILestidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lestidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172139;

    /// <inheritdoc />
    public virtual string GenusName => "Lestidium";

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
