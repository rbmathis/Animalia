using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Carpiodes;

/// <summary>
/// Abstract class for Carpiodes (genus).
/// NCBI TaxId: 154810
/// </summary>
public abstract class Carpiodes : Catostomidae, ICarpiodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carpiodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 154810;

    /// <inheritdoc />
    public virtual string GenusName => "Carpiodes";

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
