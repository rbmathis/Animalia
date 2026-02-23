using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Pseudocalotes;

/// <summary>
/// Abstract class for Pseudocalotes (genus).
/// NCBI TaxId: 118225
/// </summary>
public abstract class Pseudocalotes : Agamidae, IPseudocalotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocalotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118225;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudocalotes";

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
