using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Glyphoglossus;

/// <summary>
/// Abstract class for Glyphoglossus (genus).
/// NCBI TaxId: 310870
/// </summary>
public abstract class Glyphoglossus : Microhylidae, IGlyphoglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glyphoglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 310870;

    /// <inheritdoc />
    public virtual string GenusName => "Glyphoglossus";

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
