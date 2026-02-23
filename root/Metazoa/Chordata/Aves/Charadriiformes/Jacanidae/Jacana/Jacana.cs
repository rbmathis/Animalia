using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Jacanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Jacanidae.Jacana;

/// <summary>
/// Abstract class for Jacana (genus).
/// NCBI TaxId: 54507
/// </summary>
public abstract class Jacana : Jacanidae, IJacana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jacana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54507;

    /// <inheritdoc />
    public virtual string GenusName => "Jacana";

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
