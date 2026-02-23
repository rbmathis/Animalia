using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Pseudopodoces;

/// <summary>
/// Abstract class for Pseudopodoces (genus).
/// NCBI TaxId: 181118
/// </summary>
public abstract class Pseudopodoces : Paridae, IPseudopodoces
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudopodoces";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181118;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudopodoces";

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
