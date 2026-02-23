using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Perissocephalus;

/// <summary>
/// Abstract class for Perissocephalus (genus).
/// NCBI TaxId: 114335
/// </summary>
public abstract class Perissocephalus : Cotingidae, IPerissocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Perissocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114335;

    /// <inheritdoc />
    public virtual string GenusName => "Perissocephalus";

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
