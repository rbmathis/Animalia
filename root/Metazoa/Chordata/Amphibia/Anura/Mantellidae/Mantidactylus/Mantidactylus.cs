using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Mantidactylus;

/// <summary>
/// Abstract class for Mantidactylus (genus).
/// NCBI TaxId: 68433
/// </summary>
public abstract class Mantidactylus : Mantellidae, IMantidactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mantidactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68433;

    /// <inheritdoc />
    public virtual string GenusName => "Mantidactylus";

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
