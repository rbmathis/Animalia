using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Echidna;

/// <summary>
/// Abstract class for Echidna (genus).
/// NCBI TaxId: 189497
/// </summary>
public abstract class Echidna : Muraenidae, IEchidna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echidna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 189497;

    /// <inheritdoc />
    public virtual string GenusName => "Echidna";

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
