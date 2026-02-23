using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Aethomyias;

/// <summary>
/// Abstract class for Aethomyias (genus).
/// NCBI TaxId: 2479991
/// </summary>
public abstract class Aethomyias : Acanthizidae, IAethomyias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aethomyias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2479991;

    /// <inheritdoc />
    public virtual string GenusName => "Aethomyias";

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
