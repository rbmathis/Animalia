using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Guibemantis;

/// <summary>
/// Abstract class for Guibemantis (genus).
/// NCBI TaxId: 403240
/// </summary>
public abstract class Guibemantis : Mantellidae, IGuibemantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Guibemantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 403240;

    /// <inheritdoc />
    public virtual string GenusName => "Guibemantis";

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
