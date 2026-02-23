using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Chasiempis;

/// <summary>
/// Abstract class for Chasiempis (genus).
/// NCBI TaxId: 291284
/// </summary>
public abstract class Chasiempis : Monarchidae, IChasiempis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chasiempis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 291284;

    /// <inheritdoc />
    public virtual string GenusName => "Chasiempis";

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
