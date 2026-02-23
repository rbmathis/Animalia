using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Cyclopedidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Cyclopedidae.Cyclopes;

/// <summary>
/// Abstract class for Cyclopes (genus).
/// NCBI TaxId: 84073
/// </summary>
public abstract class Cyclopes : Cyclopedidae, ICyclopes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclopes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84073;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclopes";

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
