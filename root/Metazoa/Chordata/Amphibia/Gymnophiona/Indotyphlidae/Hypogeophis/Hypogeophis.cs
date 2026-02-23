using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Indotyphlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Indotyphlidae.Hypogeophis;

/// <summary>
/// Abstract class for Hypogeophis (genus).
/// NCBI TaxId: 8449
/// </summary>
public abstract class Hypogeophis : Indotyphlidae, IHypogeophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypogeophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8449;

    /// <inheritdoc />
    public virtual string GenusName => "Hypogeophis";

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
