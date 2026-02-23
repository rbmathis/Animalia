using AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae.Musophaga;

/// <summary>
/// Abstract class for Musophaga (genus).
/// NCBI TaxId: 103958
/// </summary>
public abstract class Musophaga : Musophagidae, IMusophaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Musophaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103958;

    /// <inheritdoc />
    public virtual string GenusName => "Musophaga";

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
