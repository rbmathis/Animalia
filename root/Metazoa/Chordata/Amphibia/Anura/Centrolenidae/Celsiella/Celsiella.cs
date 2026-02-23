using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Celsiella;

/// <summary>
/// Abstract class for Celsiella (genus).
/// NCBI TaxId: 715389
/// </summary>
public abstract class Celsiella : Centrolenidae, ICelsiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Celsiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 715389;

    /// <inheritdoc />
    public virtual string GenusName => "Celsiella";

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
