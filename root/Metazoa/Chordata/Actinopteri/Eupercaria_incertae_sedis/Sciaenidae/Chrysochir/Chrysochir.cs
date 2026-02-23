using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Chrysochir;

/// <summary>
/// Abstract class for Chrysochir (genus).
/// NCBI TaxId: 443773
/// </summary>
public abstract class Chrysochir : Sciaenidae, IChrysochir
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysochir";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443773;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysochir";

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
