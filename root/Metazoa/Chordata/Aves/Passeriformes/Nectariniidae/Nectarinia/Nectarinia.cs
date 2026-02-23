using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Nectarinia;

/// <summary>
/// Abstract class for Nectarinia (genus).
/// NCBI TaxId: 145371
/// </summary>
public abstract class Nectarinia : Nectariniidae, INectarinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nectarinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 145371;

    /// <inheritdoc />
    public virtual string GenusName => "Nectarinia";

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
