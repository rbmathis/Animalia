using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Nephelomyias;

/// <summary>
/// Abstract class for Nephelomyias (genus).
/// NCBI TaxId: 2338514
/// </summary>
public abstract class Nephelomyias : Tyrannidae, INephelomyias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nephelomyias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2338514;

    /// <inheritdoc />
    public virtual string GenusName => "Nephelomyias";

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
