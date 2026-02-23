using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Empidornis;

/// <summary>
/// Abstract class for Empidornis (genus).
/// NCBI TaxId: 757475
/// </summary>
public abstract class Empidornis : Muscicapidae, IEmpidornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Empidornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 757475;

    /// <inheritdoc />
    public virtual string GenusName => "Empidornis";

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
