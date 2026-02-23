using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Nematobrycon;

/// <summary>
/// Abstract class for Nematobrycon (genus).
/// NCBI TaxId: 272065
/// </summary>
public abstract class Nematobrycon : Acestrorhamphidae, INematobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nematobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 272065;

    /// <inheritdoc />
    public virtual string GenusName => "Nematobrycon";

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
