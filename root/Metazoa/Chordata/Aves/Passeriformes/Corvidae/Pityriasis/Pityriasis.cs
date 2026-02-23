using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Pityriasis;

/// <summary>
/// Abstract class for Pityriasis (genus).
/// NCBI TaxId: 370836
/// </summary>
public abstract class Pityriasis : Corvidae, IPityriasis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pityriasis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 370836;

    /// <inheritdoc />
    public virtual string GenusName => "Pityriasis";

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
