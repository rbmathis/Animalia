using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Larvivora;

/// <summary>
/// Abstract class for Larvivora (genus).
/// NCBI TaxId: 2013023
/// </summary>
public abstract class Larvivora : Muscicapidae, ILarvivora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Larvivora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2013023;

    /// <inheritdoc />
    public virtual string GenusName => "Larvivora";

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
