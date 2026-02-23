using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Nesoctites;

/// <summary>
/// Abstract class for Nesoctites (genus).
/// NCBI TaxId: 381876
/// </summary>
public abstract class Nesoctites : Picidae, INesoctites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesoctites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 381876;

    /// <inheritdoc />
    public virtual string GenusName => "Nesoctites";

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
