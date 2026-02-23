using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Tsingymantis;

/// <summary>
/// Abstract class for Tsingymantis (genus).
/// NCBI TaxId: 403486
/// </summary>
public abstract class Tsingymantis : Mantellidae, ITsingymantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tsingymantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 403486;

    /// <inheritdoc />
    public virtual string GenusName => "Tsingymantis";

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
