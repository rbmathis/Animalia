using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Kneriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Kneriidae.Grasseichthys;

/// <summary>
/// Abstract class for Grasseichthys (genus).
/// NCBI TaxId: 299322
/// </summary>
public abstract class Grasseichthys : Kneriidae, IGrasseichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grasseichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 299322;

    /// <inheritdoc />
    public virtual string GenusName => "Grasseichthys";

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
