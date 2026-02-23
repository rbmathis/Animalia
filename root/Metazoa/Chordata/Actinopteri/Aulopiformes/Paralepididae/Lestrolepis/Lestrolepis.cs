using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Lestrolepis;

/// <summary>
/// Abstract class for Lestrolepis (genus).
/// NCBI TaxId: 509772
/// </summary>
public abstract class Lestrolepis : Paralepididae, ILestrolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lestrolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 509772;

    /// <inheritdoc />
    public virtual string GenusName => "Lestrolepis";

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
