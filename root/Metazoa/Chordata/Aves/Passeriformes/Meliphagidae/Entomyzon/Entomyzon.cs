using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Entomyzon;

/// <summary>
/// Abstract class for Entomyzon (genus).
/// NCBI TaxId: 266348
/// </summary>
public abstract class Entomyzon : Meliphagidae, IEntomyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Entomyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266348;

    /// <inheritdoc />
    public virtual string GenusName => "Entomyzon";

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
