using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Hasemania;

/// <summary>
/// Abstract class for Hasemania (genus).
/// NCBI TaxId: 681918
/// </summary>
public abstract class Hasemania : Acestrorhamphidae, IHasemania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hasemania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681918;

    /// <inheritdoc />
    public virtual string GenusName => "Hasemania";

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
