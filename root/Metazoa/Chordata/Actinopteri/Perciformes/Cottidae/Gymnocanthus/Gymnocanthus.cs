using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Gymnocanthus;

/// <summary>
/// Abstract class for Gymnocanthus (genus).
/// NCBI TaxId: 255552
/// </summary>
public abstract class Gymnocanthus : Cottidae, IGymnocanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnocanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 255552;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnocanthus";

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
