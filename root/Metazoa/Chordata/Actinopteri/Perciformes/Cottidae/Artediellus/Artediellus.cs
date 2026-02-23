using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Artediellus;

/// <summary>
/// Abstract class for Artediellus (genus).
/// NCBI TaxId: 381888
/// </summary>
public abstract class Artediellus : Cottidae, IArtediellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Artediellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 381888;

    /// <inheritdoc />
    public virtual string GenusName => "Artediellus";

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
