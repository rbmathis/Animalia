using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Gymnocrotaphus;

/// <summary>
/// Abstract class for Gymnocrotaphus (genus).
/// NCBI TaxId: 119716
/// </summary>
public abstract class Gymnocrotaphus : Sparidae, IGymnocrotaphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnocrotaphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119716;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnocrotaphus";

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
