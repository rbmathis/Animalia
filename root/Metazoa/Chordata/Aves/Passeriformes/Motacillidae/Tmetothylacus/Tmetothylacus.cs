using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae.Tmetothylacus;

/// <summary>
/// Abstract class for Tmetothylacus (genus).
/// NCBI TaxId: 1603877
/// </summary>
public abstract class Tmetothylacus : Motacillidae, ITmetothylacus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tmetothylacus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1603877;

    /// <inheritdoc />
    public virtual string GenusName => "Tmetothylacus";

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
