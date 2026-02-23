using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Climacteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Climacteridae.Climacteris;

/// <summary>
/// Abstract class for Climacteris (genus).
/// NCBI TaxId: 47694
/// </summary>
public abstract class Climacteris : Climacteridae, IClimacteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Climacteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47694;

    /// <inheritdoc />
    public virtual string GenusName => "Climacteris";

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
