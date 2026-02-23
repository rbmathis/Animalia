using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Apterichtus;

/// <summary>
/// Abstract class for Apterichtus (genus).
/// NCBI TaxId: 1156448
/// </summary>
public abstract class Apterichtus : Ophichthidae, IApterichtus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apterichtus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1156448;

    /// <inheritdoc />
    public virtual string GenusName => "Apterichtus";

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
