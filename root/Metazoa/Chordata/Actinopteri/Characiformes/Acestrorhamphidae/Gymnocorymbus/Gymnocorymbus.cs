using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Gymnocorymbus;

/// <summary>
/// Abstract class for Gymnocorymbus (genus).
/// NCBI TaxId: 42493
/// </summary>
public abstract class Gymnocorymbus : Acestrorhamphidae, IGymnocorymbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnocorymbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42493;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnocorymbus";

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
