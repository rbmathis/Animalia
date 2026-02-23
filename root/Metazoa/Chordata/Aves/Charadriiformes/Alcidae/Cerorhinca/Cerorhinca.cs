using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Cerorhinca;

/// <summary>
/// Abstract class for Cerorhinca (genus).
/// NCBI TaxId: 43309
/// </summary>
public abstract class Cerorhinca : Alcidae, ICerorhinca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cerorhinca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43309;

    /// <inheritdoc />
    public virtual string GenusName => "Cerorhinca";

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
