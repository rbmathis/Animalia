using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Creagrus;

/// <summary>
/// Abstract class for Creagrus (genus).
/// NCBI TaxId: 128047
/// </summary>
public abstract class Creagrus : Laridae, ICreagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Creagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 128047;

    /// <inheritdoc />
    public virtual string GenusName => "Creagrus";

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
