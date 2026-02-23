using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Tityra;

/// <summary>
/// Abstract class for Tityra (genus).
/// NCBI TaxId: 114386
/// </summary>
public abstract class Tityra : Tyrannidae, ITityra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tityra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114386;

    /// <inheritdoc />
    public virtual string GenusName => "Tityra";

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
