using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Procarduelis;

/// <summary>
/// Abstract class for Procarduelis (genus).
/// NCBI TaxId: 2823184
/// </summary>
public abstract class Procarduelis : Fringillidae, IProcarduelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Procarduelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823184;

    /// <inheritdoc />
    public virtual string GenusName => "Procarduelis";

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
