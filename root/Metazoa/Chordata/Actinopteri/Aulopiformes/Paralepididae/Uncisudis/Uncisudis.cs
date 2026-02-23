using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Uncisudis;

/// <summary>
/// Abstract class for Uncisudis (genus).
/// NCBI TaxId: 2100603
/// </summary>
public abstract class Uncisudis : Paralepididae, IUncisudis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uncisudis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2100603;

    /// <inheritdoc />
    public virtual string GenusName => "Uncisudis";

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
