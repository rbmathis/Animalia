using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Heteromyias;

/// <summary>
/// Abstract class for Heteromyias (genus).
/// NCBI TaxId: 38564
/// </summary>
public abstract class Heteromyias : Petroicidae, IHeteromyias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteromyias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38564;

    /// <inheritdoc />
    public virtual string GenusName => "Heteromyias";

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
