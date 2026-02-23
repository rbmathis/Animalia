using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Cercotrichas;

/// <summary>
/// Abstract class for Cercotrichas (genus).
/// NCBI TaxId: 228304
/// </summary>
public abstract class Cercotrichas : Muscicapidae, ICercotrichas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cercotrichas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 228304;

    /// <inheritdoc />
    public virtual string GenusName => "Cercotrichas";

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
