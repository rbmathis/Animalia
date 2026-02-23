using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Megophrys;

/// <summary>
/// Abstract class for Megophrys (genus).
/// NCBI TaxId: 247085
/// </summary>
public abstract class Megophrys : Megophryidae, IMegophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247085;

    /// <inheritdoc />
    public virtual string GenusName => "Megophrys";

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
