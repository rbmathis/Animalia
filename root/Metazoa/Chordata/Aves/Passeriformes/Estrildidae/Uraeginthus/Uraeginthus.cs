using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Uraeginthus;

/// <summary>
/// Abstract class for Uraeginthus (genus).
/// NCBI TaxId: 247536
/// </summary>
public abstract class Uraeginthus : Estrildidae, IUraeginthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uraeginthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247536;

    /// <inheritdoc />
    public virtual string GenusName => "Uraeginthus";

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
