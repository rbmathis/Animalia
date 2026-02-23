using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae.Bleekeria;

/// <summary>
/// Abstract class for Bleekeria (genus).
/// NCBI TaxId: 1916793
/// </summary>
public abstract class Bleekeria : Plesiopidae, IBleekeria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bleekeria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1916793;

    /// <inheritdoc />
    public virtual string GenusName => "Bleekeria";

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
