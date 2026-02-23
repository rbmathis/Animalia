using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Sublegatus;

/// <summary>
/// Abstract class for Sublegatus (genus).
/// NCBI TaxId: 183544
/// </summary>
public abstract class Sublegatus : Tyrannidae, ISublegatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sublegatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183544;

    /// <inheritdoc />
    public virtual string GenusName => "Sublegatus";

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
