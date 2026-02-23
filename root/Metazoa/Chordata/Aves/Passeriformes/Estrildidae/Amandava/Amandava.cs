using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Amandava;

/// <summary>
/// Abstract class for Amandava (genus).
/// NCBI TaxId: 187412
/// </summary>
public abstract class Amandava : Estrildidae, IAmandava
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amandava";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187412;

    /// <inheritdoc />
    public virtual string GenusName => "Amandava";

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
