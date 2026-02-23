using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Larosterna;

/// <summary>
/// Abstract class for Larosterna (genus).
/// NCBI TaxId: 297810
/// </summary>
public abstract class Larosterna : Laridae, ILarosterna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Larosterna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 297810;

    /// <inheritdoc />
    public virtual string GenusName => "Larosterna";

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
