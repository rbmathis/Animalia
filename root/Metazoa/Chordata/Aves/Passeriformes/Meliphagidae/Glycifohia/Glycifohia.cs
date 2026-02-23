using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Glycifohia;

/// <summary>
/// Abstract class for Glycifohia (genus).
/// NCBI TaxId: 1439372
/// </summary>
public abstract class Glycifohia : Meliphagidae, IGlycifohia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glycifohia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1439372;

    /// <inheritdoc />
    public virtual string GenusName => "Glycifohia";

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
