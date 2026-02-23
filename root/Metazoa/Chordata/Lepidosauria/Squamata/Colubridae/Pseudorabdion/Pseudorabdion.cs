using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Pseudorabdion;

/// <summary>
/// Abstract class for Pseudorabdion (genus).
/// NCBI TaxId: 186560
/// </summary>
public abstract class Pseudorabdion : Colubridae, IPseudorabdion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudorabdion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186560;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudorabdion";

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
