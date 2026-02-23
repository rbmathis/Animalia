using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Sachatamia;

/// <summary>
/// Abstract class for Sachatamia (genus).
/// NCBI TaxId: 715370
/// </summary>
public abstract class Sachatamia : Centrolenidae, ISachatamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sachatamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 715370;

    /// <inheritdoc />
    public virtual string GenusName => "Sachatamia";

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
