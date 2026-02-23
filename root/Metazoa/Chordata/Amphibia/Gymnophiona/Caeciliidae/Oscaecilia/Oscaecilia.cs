using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Caeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Caeciliidae.Oscaecilia;

/// <summary>
/// Abstract class for Oscaecilia (genus).
/// NCBI TaxId: 264008
/// </summary>
public abstract class Oscaecilia : Caeciliidae, IOscaecilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oscaecilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 264008;

    /// <inheritdoc />
    public virtual string GenusName => "Oscaecilia";

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
