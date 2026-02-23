using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Rhinobrycon;

/// <summary>
/// Abstract class for Rhinobrycon (genus).
/// NCBI TaxId: 1463128
/// </summary>
public abstract class Rhinobrycon : Stevardiidae, IRhinobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1463128;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinobrycon";

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
