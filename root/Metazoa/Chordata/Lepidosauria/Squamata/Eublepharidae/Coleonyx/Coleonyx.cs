using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Eublepharidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Eublepharidae.Coleonyx;

/// <summary>
/// Abstract class for Coleonyx (genus).
/// NCBI TaxId: 52434
/// </summary>
public abstract class Coleonyx : Eublepharidae, IColeonyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coleonyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52434;

    /// <inheritdoc />
    public virtual string GenusName => "Coleonyx";

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
