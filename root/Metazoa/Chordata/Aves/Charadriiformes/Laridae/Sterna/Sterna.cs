using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Sterna;

/// <summary>
/// Abstract class for Sterna (genus).
/// NCBI TaxId: 70608
/// </summary>
public abstract class Sterna : Laridae, ISterna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sterna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70608;

    /// <inheritdoc />
    public virtual string GenusName => "Sterna";

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
