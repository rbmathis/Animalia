using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bombinatoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bombinatoridae.Bombina;

/// <summary>
/// Abstract class for Bombina (genus).
/// NCBI TaxId: 8344
/// </summary>
public abstract class Bombina : Bombinatoridae, IBombina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bombina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8344;

    /// <inheritdoc />
    public virtual string GenusName => "Bombina";

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
