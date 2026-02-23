using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Philohydor;

/// <summary>
/// Abstract class for Philohydor (genus).
/// NCBI TaxId: 478648
/// </summary>
public abstract class Philohydor : Tyrannidae, IPhilohydor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Philohydor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 478648;

    /// <inheritdoc />
    public virtual string GenusName => "Philohydor";

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
