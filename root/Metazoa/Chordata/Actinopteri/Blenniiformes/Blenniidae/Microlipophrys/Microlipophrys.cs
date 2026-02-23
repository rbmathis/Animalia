using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Microlipophrys;

/// <summary>
/// Abstract class for Microlipophrys (genus).
/// NCBI TaxId: 914082
/// </summary>
public abstract class Microlipophrys : Blenniidae, IMicrolipophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microlipophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 914082;

    /// <inheritdoc />
    public virtual string GenusName => "Microlipophrys";

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
