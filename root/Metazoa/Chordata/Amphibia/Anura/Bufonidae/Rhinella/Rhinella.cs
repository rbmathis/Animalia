using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Rhinella;

/// <summary>
/// Abstract class for Rhinella (genus).
/// NCBI TaxId: 651667
/// </summary>
public abstract class Rhinella : Bufonidae, IRhinella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651667;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinella";

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
