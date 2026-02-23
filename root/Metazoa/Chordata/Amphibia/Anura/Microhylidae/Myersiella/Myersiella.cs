using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Myersiella;

/// <summary>
/// Abstract class for Myersiella (genus).
/// NCBI TaxId: 1271634
/// </summary>
public abstract class Myersiella : Microhylidae, IMyersiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myersiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1271634;

    /// <inheritdoc />
    public virtual string GenusName => "Myersiella";

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
