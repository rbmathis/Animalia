using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Agricola;

/// <summary>
/// Abstract class for Agricola (genus).
/// NCBI TaxId: 3150752
/// </summary>
public abstract class Agricola : Muscicapidae, IAgricola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agricola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150752;

    /// <inheritdoc />
    public virtual string GenusName => "Agricola";

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
