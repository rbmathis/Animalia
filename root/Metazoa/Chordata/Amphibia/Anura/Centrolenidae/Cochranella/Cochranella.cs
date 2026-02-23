using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Cochranella;

/// <summary>
/// Abstract class for Cochranella (genus).
/// NCBI TaxId: 159186
/// </summary>
public abstract class Cochranella : Centrolenidae, ICochranella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cochranella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 159186;

    /// <inheritdoc />
    public virtual string GenusName => "Cochranella";

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
