using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Monotremata.Tachyglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Monotremata.Tachyglossidae.Tachyglossus;

/// <summary>
/// Abstract class for Tachyglossus (genus).
/// NCBI TaxId: 9260
/// </summary>
public abstract class Tachyglossus : Tachyglossidae, ITachyglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tachyglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9260;

    /// <inheritdoc />
    public virtual string GenusName => "Tachyglossus";

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
