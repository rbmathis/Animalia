using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Paralepis;

/// <summary>
/// Abstract class for Paralepis (genus).
/// NCBI TaxId: 509776
/// </summary>
public abstract class Paralepis : Paralepididae, IParalepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paralepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 509776;

    /// <inheritdoc />
    public virtual string GenusName => "Paralepis";

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
