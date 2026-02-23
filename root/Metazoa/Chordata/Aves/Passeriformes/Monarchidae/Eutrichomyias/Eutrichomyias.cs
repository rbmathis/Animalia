using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Eutrichomyias;

/// <summary>
/// Abstract class for Eutrichomyias (genus).
/// NCBI TaxId: 461251
/// </summary>
public abstract class Eutrichomyias : Monarchidae, IEutrichomyias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eutrichomyias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 461251;

    /// <inheritdoc />
    public virtual string GenusName => "Eutrichomyias";

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
