using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Centrolene;

/// <summary>
/// Abstract class for Centrolene (genus).
/// NCBI TaxId: 43458
/// </summary>
public abstract class Centrolene : Centrolenidae, ICentrolene
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centrolene";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43458;

    /// <inheritdoc />
    public virtual string GenusName => "Centrolene";

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
