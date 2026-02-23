using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Chlorophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Chlorophthalmidae.Parasudis;

/// <summary>
/// Abstract class for Parasudis (genus).
/// NCBI TaxId: 509778
/// </summary>
public abstract class Parasudis : Chlorophthalmidae, IParasudis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parasudis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 509778;

    /// <inheritdoc />
    public virtual string GenusName => "Parasudis";

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
