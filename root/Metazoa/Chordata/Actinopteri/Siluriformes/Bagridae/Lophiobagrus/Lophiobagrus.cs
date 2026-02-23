using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Lophiobagrus;

/// <summary>
/// Abstract class for Lophiobagrus (genus).
/// NCBI TaxId: 390423
/// </summary>
public abstract class Lophiobagrus : Bagridae, ILophiobagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophiobagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390423;

    /// <inheritdoc />
    public virtual string GenusName => "Lophiobagrus";

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
