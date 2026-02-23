using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Chlopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Chlopsidae.Chilorhinus;

/// <summary>
/// Abstract class for Chilorhinus (genus).
/// NCBI TaxId: 182422
/// </summary>
public abstract class Chilorhinus : Chlopsidae, IChilorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chilorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182422;

    /// <inheritdoc />
    public virtual string GenusName => "Chilorhinus";

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
