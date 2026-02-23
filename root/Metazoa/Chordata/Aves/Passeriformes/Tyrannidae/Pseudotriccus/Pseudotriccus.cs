using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Pseudotriccus;

/// <summary>
/// Abstract class for Pseudotriccus (genus).
/// NCBI TaxId: 360245
/// </summary>
public abstract class Pseudotriccus : Tyrannidae, IPseudotriccus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudotriccus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 360245;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudotriccus";

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
