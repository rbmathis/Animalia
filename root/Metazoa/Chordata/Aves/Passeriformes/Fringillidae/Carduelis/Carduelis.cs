using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Carduelis;

/// <summary>
/// Abstract class for Carduelis (genus).
/// NCBI TaxId: 36252
/// </summary>
public abstract class Carduelis : Fringillidae, ICarduelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carduelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36252;

    /// <inheritdoc />
    public virtual string GenusName => "Carduelis";

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
