using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Kathala;

/// <summary>
/// Abstract class for Kathala (genus).
/// NCBI TaxId: 3362511
/// </summary>
public abstract class Kathala : Sciaenidae, IKathala
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kathala";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362511;

    /// <inheritdoc />
    public virtual string GenusName => "Kathala";

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
