using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Cymbacephalus;

/// <summary>
/// Abstract class for Cymbacephalus (genus).
/// NCBI TaxId: 334930
/// </summary>
public abstract class Cymbacephalus : Platycephalidae, ICymbacephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cymbacephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334930;

    /// <inheritdoc />
    public virtual string GenusName => "Cymbacephalus";

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
