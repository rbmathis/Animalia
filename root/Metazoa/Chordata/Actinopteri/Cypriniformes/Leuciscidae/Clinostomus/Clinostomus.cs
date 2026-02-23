using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Clinostomus;

/// <summary>
/// Abstract class for Clinostomus (genus).
/// NCBI TaxId: 86939
/// </summary>
public abstract class Clinostomus : Leuciscidae, IClinostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clinostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86939;

    /// <inheritdoc />
    public virtual string GenusName => "Clinostomus";

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
