using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amblycipitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amblycipitidae.Liobagrus;

/// <summary>
/// Abstract class for Liobagrus (genus).
/// NCBI TaxId: 78874
/// </summary>
public abstract class Liobagrus : Amblycipitidae, ILiobagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liobagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 78874;

    /// <inheritdoc />
    public virtual string GenusName => "Liobagrus";

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
