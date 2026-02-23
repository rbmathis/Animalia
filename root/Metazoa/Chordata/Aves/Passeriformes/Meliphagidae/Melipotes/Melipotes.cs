using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Melipotes;

/// <summary>
/// Abstract class for Melipotes (genus).
/// NCBI TaxId: 108833
/// </summary>
public abstract class Melipotes : Meliphagidae, IMelipotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melipotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 108833;

    /// <inheritdoc />
    public virtual string GenusName => "Melipotes";

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
