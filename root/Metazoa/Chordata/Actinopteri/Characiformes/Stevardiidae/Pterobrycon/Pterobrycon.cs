using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Pterobrycon;

/// <summary>
/// Abstract class for Pterobrycon (genus).
/// NCBI TaxId: 2489305
/// </summary>
public abstract class Pterobrycon : Stevardiidae, IPterobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2489305;

    /// <inheritdoc />
    public virtual string GenusName => "Pterobrycon";

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
