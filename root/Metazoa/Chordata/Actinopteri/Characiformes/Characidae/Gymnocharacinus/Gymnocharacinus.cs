using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Gymnocharacinus;

/// <summary>
/// Abstract class for Gymnocharacinus (genus).
/// NCBI TaxId: 2219205
/// </summary>
public abstract class Gymnocharacinus : Characidae, IGymnocharacinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnocharacinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2219205;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnocharacinus";

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
