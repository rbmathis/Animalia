using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Morerella;

/// <summary>
/// Abstract class for Morerella (genus).
/// NCBI TaxId: 643480
/// </summary>
public abstract class Morerella : Hyperoliidae, IMorerella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Morerella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643480;

    /// <inheritdoc />
    public virtual string GenusName => "Morerella";

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
