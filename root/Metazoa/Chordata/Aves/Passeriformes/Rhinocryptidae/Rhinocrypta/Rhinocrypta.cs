using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Rhinocrypta;

/// <summary>
/// Abstract class for Rhinocrypta (genus).
/// NCBI TaxId: 137538
/// </summary>
public abstract class Rhinocrypta : Rhinocryptidae, IRhinocrypta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinocrypta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137538;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinocrypta";

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
