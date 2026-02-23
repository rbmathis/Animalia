using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Crossosalarias;

/// <summary>
/// Abstract class for Crossosalarias (genus).
/// NCBI TaxId: 1405694
/// </summary>
public abstract class Crossosalarias : Blenniidae, ICrossosalarias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crossosalarias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1405694;

    /// <inheritdoc />
    public virtual string GenusName => "Crossosalarias";

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
