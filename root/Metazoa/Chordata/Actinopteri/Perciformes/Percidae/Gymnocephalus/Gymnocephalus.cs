using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Gymnocephalus;

/// <summary>
/// Abstract class for Gymnocephalus (genus).
/// NCBI TaxId: 39193
/// </summary>
public abstract class Gymnocephalus : Percidae, IGymnocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39193;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnocephalus";

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
