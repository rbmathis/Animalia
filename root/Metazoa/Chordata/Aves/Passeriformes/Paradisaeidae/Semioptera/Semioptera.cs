using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae.Semioptera;

/// <summary>
/// Abstract class for Semioptera (genus).
/// NCBI TaxId: 681209
/// </summary>
public abstract class Semioptera : Paradisaeidae, ISemioptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Semioptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681209;

    /// <inheritdoc />
    public virtual string GenusName => "Semioptera";

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
