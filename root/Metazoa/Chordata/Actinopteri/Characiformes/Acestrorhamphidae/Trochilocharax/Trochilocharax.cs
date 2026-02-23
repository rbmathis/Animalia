using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Trochilocharax;

/// <summary>
/// Abstract class for Trochilocharax (genus).
/// NCBI TaxId: 2608203
/// </summary>
public abstract class Trochilocharax : Acestrorhamphidae, ITrochilocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trochilocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608203;

    /// <inheritdoc />
    public virtual string GenusName => "Trochilocharax";

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
