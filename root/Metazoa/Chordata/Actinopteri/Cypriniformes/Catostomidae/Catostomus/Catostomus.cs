using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Catostomus;

/// <summary>
/// Abstract class for Catostomus (genus).
/// NCBI TaxId: 7969
/// </summary>
public abstract class Catostomus : Catostomidae, ICatostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Catostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7969;

    /// <inheritdoc />
    public virtual string GenusName => "Catostomus";

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
