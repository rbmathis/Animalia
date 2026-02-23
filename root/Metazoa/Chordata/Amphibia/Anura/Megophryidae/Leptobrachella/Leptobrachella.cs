using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Leptobrachella;

/// <summary>
/// Abstract class for Leptobrachella (genus).
/// NCBI TaxId: 1534316
/// </summary>
public abstract class Leptobrachella : Megophryidae, ILeptobrachella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptobrachella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1534316;

    /// <inheritdoc />
    public virtual string GenusName => "Leptobrachella";

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
