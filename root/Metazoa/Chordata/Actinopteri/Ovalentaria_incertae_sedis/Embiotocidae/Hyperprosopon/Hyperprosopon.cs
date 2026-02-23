using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae.Hyperprosopon;

/// <summary>
/// Abstract class for Hyperprosopon (genus).
/// NCBI TaxId: 100191
/// </summary>
public abstract class Hyperprosopon : Embiotocidae, IHyperprosopon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyperprosopon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 100191;

    /// <inheritdoc />
    public virtual string GenusName => "Hyperprosopon";

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
