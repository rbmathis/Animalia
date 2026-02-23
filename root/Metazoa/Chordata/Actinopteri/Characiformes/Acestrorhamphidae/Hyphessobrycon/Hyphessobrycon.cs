using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Hyphessobrycon;

/// <summary>
/// Abstract class for Hyphessobrycon (genus).
/// NCBI TaxId: 188718
/// </summary>
public abstract class Hyphessobrycon : Acestrorhamphidae, IHyphessobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyphessobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 188718;

    /// <inheritdoc />
    public virtual string GenusName => "Hyphessobrycon";

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
