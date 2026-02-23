using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Todirostrum;

/// <summary>
/// Abstract class for Todirostrum (genus).
/// NCBI TaxId: 196048
/// </summary>
public abstract class Todirostrum : Tyrannidae, ITodirostrum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Todirostrum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 196048;

    /// <inheritdoc />
    public virtual string GenusName => "Todirostrum";

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
