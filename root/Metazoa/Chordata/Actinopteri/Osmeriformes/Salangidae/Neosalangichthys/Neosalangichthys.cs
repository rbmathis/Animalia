using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae.Neosalangichthys;

/// <summary>
/// Abstract class for Neosalangichthys (genus).
/// NCBI TaxId: 2905918
/// </summary>
public abstract class Neosalangichthys : Salangidae, INeosalangichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neosalangichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2905918;

    /// <inheritdoc />
    public virtual string GenusName => "Neosalangichthys";

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
