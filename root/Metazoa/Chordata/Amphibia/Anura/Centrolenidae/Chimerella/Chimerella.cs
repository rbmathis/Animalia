using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Chimerella;

/// <summary>
/// Abstract class for Chimerella (genus).
/// NCBI TaxId: 715379
/// </summary>
public abstract class Chimerella : Centrolenidae, IChimerella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chimerella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 715379;

    /// <inheritdoc />
    public virtual string GenusName => "Chimerella";

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
