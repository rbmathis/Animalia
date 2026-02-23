using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Horabagrus;

/// <summary>
/// Abstract class for Horabagrus (genus).
/// NCBI TaxId: 337738
/// </summary>
public abstract class Horabagrus : Bagridae, IHorabagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Horabagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337738;

    /// <inheritdoc />
    public virtual string GenusName => "Horabagrus";

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
