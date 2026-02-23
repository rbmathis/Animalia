using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Spicospina;

/// <summary>
/// Abstract class for Spicospina (genus).
/// NCBI TaxId: 356331
/// </summary>
public abstract class Spicospina : Myobatrachidae, ISpicospina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spicospina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356331;

    /// <inheritdoc />
    public virtual string GenusName => "Spicospina";

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
