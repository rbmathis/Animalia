using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Waikhomia;

/// <summary>
/// Abstract class for Waikhomia (genus).
/// NCBI TaxId: 2773785
/// </summary>
public abstract class Waikhomia : Cyprinidae, IWaikhomia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Waikhomia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2773785;

    /// <inheritdoc />
    public virtual string GenusName => "Waikhomia";

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
