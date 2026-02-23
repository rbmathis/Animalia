using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Parodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Parodontidae.Parodon;

/// <summary>
/// Abstract class for Parodon (genus).
/// NCBI TaxId: 304074
/// </summary>
public abstract class Parodon : Parodontidae, IParodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304074;

    /// <inheritdoc />
    public virtual string GenusName => "Parodon";

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
