using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Xyrauchen;

/// <summary>
/// Abstract class for Xyrauchen (genus).
/// NCBI TaxId: 154826
/// </summary>
public abstract class Xyrauchen : Catostomidae, IXyrauchen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xyrauchen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 154826;

    /// <inheritdoc />
    public virtual string GenusName => "Xyrauchen";

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
